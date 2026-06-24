using Commons.Enums;
using Commons.Helper;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Models.Config;

namespace WS_CheckSimVNPT
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceProvider _provider;
        private readonly IHostApplicationLifetime _hostApplicationLifetime;
        private readonly IConfiguration _configuration;

        public Worker(ILogger<Worker> logger, IServiceProvider provider, IHostApplicationLifetime hostApplicationLifetime, IConfiguration configuration)
        {
            _logger = logger;
            _provider = provider;
            _hostApplicationLifetime = hostApplicationLifetime;
            _configuration = configuration;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Send mail running at: {time}", DateTimeOffset.Now);
            try
            {
                var mailSetting = _configuration.GetSection("MailSetting").Get<MailSetting>();

                //Open connection DB
                using var scope = _provider.CreateScope();
                var db = scope.ServiceProvider.GetRequiredService<SIMCenterDbContext>();

                //Gửi mail phiên đấu giá vừa xong
                var auction = db.Auctions.Where(x => x.StartTime <= DateTime.Now.AddDays(-1) && x.EndTime > DateTime.Now.AddDays(-1));
                if (auction != null)
                {
                    //Gửi mail
                    var createByEmail = db.Users.Where(x => x.Id == auction.FirstOrDefault().CreateBy).Select(x => x.Email).FirstOrDefault();
                    var auctionStr = string.Join(", ", auction.Select(x => x.Name).ToList());
                    var dauGiaContent = _configuration.GetSection("DauGiaContent").Get<MailContent>();
                    dauGiaContent.Subject = dauGiaContent.Body.Replace("{0}", DateTime.Now.ToString("dd/MM/yyyy"));
                    dauGiaContent.Body = dauGiaContent.Body.Replace("{0}", auctionStr);
                    MailHelper.SendMailGoogleSmtp(mailSetting.MailAddress, "simhathanh.mailservice@gmail.com", dauGiaContent.Subject, dauGiaContent.Body, mailSetting.Password);

                    //Tạo đơn hỏi mua
                    foreach (var auc in auction.ToList())
                    {
                        var userWin = db.AuctionUserBiddings.Where(x => x.AuctionId == auc.Id).OrderByDescending(x => x.Price).FirstOrDefault();
                        var deposit = db.SystemConfigs.FirstOrDefault()?.Auction_Deposit ?? 0;
                        if (userWin != null)
                        {
                            var userBuy = db.Users.FirstOrDefault(x => x.Id == userWin.UserId);
                            //Create SIM
                            var dataNew = new SIMOrder()
                            {
                                Address = userBuy.Address,
                                UserBuyId = userBuy.Id,
                                Name = userBuy?.FullName ?? "",
                                PhoneNum = userBuy.PhoneNumber,
                                PriceOrder = userWin.Price,
                                SIMEmbryoFee = 0,
                                SIMServiceFee = 0,
                                Note = $"Đơn hàng cho người thắng phiên đấu giá: {auc.Name} (đã trừ cọc {deposit})",
                                Status = StatusOrder.Order,
                                CreateBy = new Guid(),
                                UpdateBy = new Guid(),
                                PIC = new Guid("C09B6C9B-3405-4ABB-B39F-2FAA705226D8"),
                                CreateTime = DateTime.Now,
                                UpdateTime = DateTime.Now,
                                TimeUnlock = DateTime.Now.AddHours(24),
                                //
                                PayOrderType = PaymentType.COD,
                                InstallmentPeriod = 0,
                                DateOfPayment = 0,
                                InstallmentEndDate = DateTime.Now,
                                DownPayment = 0,
                                InstallmentPayment = 0,
                                MonthlyInstallmentPayment = 0,
                                InterestRate = 0,
                            };

                            db.SIMOrders.Add(dataNew);
                            var result = db.SaveChanges();

                            db.SIMWithOrders.Add(new SIMWithOrder()
                            {
                                OrderId = dataNew.Id,
                                SimId = auc.SimId,
                            });

                            _logger.LogInformation("Tạo đơn hỏi mua cho đấu giá thành công: " + auc.Name);

                            //Gửi notify thông báo cho người dùng
                            var dataNoti = new Notification()
                            {
                                Title = "Đấu giá thành công phiên đấu giá " + auc.Name,
                                Content = "Xin chúc mừng, bạn là người chơi may mắn đã đấu giá thành công sim " + auc.SimNumber + " với giá " + userWin.Price + ". Chúng tôi sẽ liên hệ và trao thưởng đến bán trong thời gian sớm nhất. \n Trân trọng",
                                //CollaboratorsGroupId = request.CollaboratorsGroupId,
                                ImageUrl = "",
                                CreateBy = new Guid(),
                                UpdateBy = new Guid(),
                                CreateTime = DateTime.Now,
                                UpdateTime = DateTime.Now,
                            };

                            db.Notifications.Add(dataNoti);
                            db.SaveChanges();

                            var notiUser = new NotificationUser()
                            {
                                NotificationId = dataNoti.Id,
                                UserId = userBuy.Id,
                                IsRead = false,
                                CreateBy = new Guid(),
                                UpdateBy = new Guid(),
                                CreateTime = DateTime.Now,
                                UpdateTime = DateTime.Now,
                            };
                            db.NotificationUsers.Add(notiUser);
                            db.SaveChanges();

                            //Tạo giao dịch trừ cọc vào quỹ
                            var cashBook = new CashBook()
                            {
                                UserId = userBuy.Id,
                                cashActionType = CashActionType.DauGia,
                                Liabilities = deposit,
                                Receivables = 0,
                                FinalDebt = 0 - deposit,
                                approvedStatus = ApprovedStatus.Approved,
                                Description = "Trừ tiền cọc sim đấu giá thành công",
                                Note = "Hệ thống đã trừ tiền",
                                OnApp = true,
                                IsDelete = false,
                                CreateBy = new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                                UpdateBy = new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                                CreateTime = DateTime.Now,
                                UpdateTime = DateTime.Now,
                            };

                            db.CashBooks.Add(cashBook);
                            db.SaveChanges();
                        }
                    }
                    db.SaveChanges();

                }

                //Gửi mail nhắc thu nợ
                var gdns = db.GoodsDeliveryNoteOfSim.Where(x => x.PayOrderType == Commons.Enums.PaymentType.Installment && x.DateOfPayment == DateTime.Now.Day && x.approvedStatus == Commons.Enums.ApprovedStatus.Approved);
                if (gdns != null)
                {
                    //var gdnsCodeStr = string.Join(", ", gdns.Select(x => x.Code).ToList());
                    var traGopContent = _configuration.GetSection("TraGopContent").Get<MailContent>();
                    traGopContent.Subject = traGopContent.Body.Replace("{0}", DateTime.Now.ToString("dd/MM/yyyy"));
                    //Gửi mail
                    foreach (var item in gdns)
                    {
                        var createByEmail = db.Users.Where(x => x.Id == item.CreateBy).Select(x => x.Email).FirstOrDefault();
                        traGopContent.Body = traGopContent.Body.Replace("{0}", item.Code);
                        MailHelper.SendMailGoogleSmtp(mailSetting.MailAddress, createByEmail ?? "", traGopContent.Subject, traGopContent.Body, mailSetting.Password);

                        _logger.LogInformation("Nhắc thu nợ đơn: " + item.Code);

                        //Gửi notify thông báo cho người dùng
                        var dataNoti = new Notification()
                        {
                            Title = "Đơn hàng trả góp đã đến hạn thanh toán.",
                            Content = "Đơn hàng mua sim " + item.ListSimNumberInOrder + " của bạn đã đến hạn thanh toán. Vui lòng thanh toán số tiền " + item.InstallmentPayment + " trước ngày " + item.DateOfPayment + ". \n Trân trọng",
                            //CollaboratorsGroupId = request.CollaboratorsGroupId,
                            ImageUrl = "",
                            CreateBy = new Guid(),
                            UpdateBy = new Guid(),
                            CreateTime = DateTime.Now,
                            UpdateTime = DateTime.Now,
                        };

                        db.Notifications.Add(dataNoti);
                        db.SaveChanges();

                        var notiUser = new NotificationUser()
                        {
                            NotificationId = dataNoti.Id,
                            UserId = item.CustomerId ?? new Guid(),
                            IsRead = false,
                            CreateBy = new Guid(),
                            UpdateBy = new Guid(),
                            CreateTime = DateTime.Now,
                            UpdateTime = DateTime.Now,
                        };
                        db.NotificationUsers.Add(notiUser);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            finally
            {
                _logger.LogInformation("Send mail is stopped..");
                _hostApplicationLifetime.StopApplication();
            }
        }
    }
}