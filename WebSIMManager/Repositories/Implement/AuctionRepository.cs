using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Newtonsoft.Json;
using Repositories.Interface;
using System.Reflection;

namespace Repositories.Implement
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;
        private readonly CashBookRepository _cashBook;
        public AuctionRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new(context);
            _cashBook = new(context);
        }

        public ResponseDataViewModel<AuctionViewModel> GetCurentAuction()
        {
            try
            {
                ResponseDataViewModel<AuctionViewModel> result = new();
                var query = from auc in _context.Auctions
                            join sim in _context.SIMDetails on auc.SimId equals sim.Id
                            join network in _context.SIMNetworks on sim.SIMNetworkId equals network.Id
                            where auc.StartTime <= DateTime.Now && auc.EndTime >= DateTime.Now
                            orderby auc.CreateTime descending
                            select new { auc, network };
                var dataPaging = query.ToList();
                List<AuctionViewModel> data = new();
                foreach (var item in dataPaging)
                {
                    var bidderNum = _context.AuctionUserBiddings.Where(x => x.AuctionId == item.auc.Id).Count();
                    AuctionUserBiddingModel winner = new();
                    var userWin = _context.AuctionUserBiddings.Where(x => x.AuctionId == item.auc.Id).OrderByDescending(x => x.Price).FirstOrDefault();
                    if (userWin != null)
                    {
                        winner.Id = userWin.Id;
                        winner.AuctionId = userWin.AuctionId;
                        winner.Price = userWin.Price;
                        winner.UserId = userWin.UserId;
                        winner.UserName = userWin.UserName;
                    }
                    data.Add(new AuctionViewModel()
                    {
                        Id = item.auc.Id,
                        Name = item.auc.Name,
                        StartTime = item.auc.StartTime,
                        EndTime = item.auc.EndTime,
                        SimId = item.auc.SimId,
                        SimNumber = item.auc.SimNumber,
                        Network = item.network.NetworkName,
                        AuctionPrice = item.auc.AuctionPrice,
                        BidderNum = bidderNum,
                        Note = item.auc.Note,
                        BiddingWin = winner
                    });
                }
                return new ResponseDataViewModel<AuctionViewModel>()
                {
                    Pager = new Pager(new PagingRequestBase() { keyword = "", pageIndex = 0, pageSize = query.Count() }, query.Count()),
                    Data = data
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataViewModel<AuctionViewModel>();
            }
        }

        public ResponseDataViewModel<AuctionViewModel> GetAuction(GetPagingRequest request)
        {
            try
            {
                if (request.keyword == null) request.keyword = string.Empty;
                ResponseDataViewModel<AuctionModel> result = new();
                var query = from auc in _context.Auctions
                            join sim in _context.SIMDetails on auc.SimId equals sim.Id
                            join network in _context.SIMNetworks on sim.SIMNetworkId equals network.Id
                            where auc.Name.Contains(request.keyword)
                            orderby auc.CreateTime descending
                            select new { auc, network };
                var dataPaging = query.ToList().Skip(request.pageIndex - 1).Take(request.pageSize);
                List<AuctionViewModel> data = new();
                foreach (var item in dataPaging)
                {
                    var bidderNum = _context.AuctionUserBiddings.Where(x => x.AuctionId == item.auc.Id).Count();
                    AuctionUserBiddingModel winner = new();

                    var userWin = _context.AuctionUserBiddings.Where(x => x.AuctionId == item.auc.Id).OrderByDescending(x => x.Price).FirstOrDefault();
                    if (userWin != null)
                    {
                        winner.Id = userWin.Id;
                        winner.AuctionId = userWin.AuctionId;
                        winner.Price = userWin.Price;
                        winner.UserId = userWin.UserId;
                        winner.UserName = userWin.UserName;
                    }
                    data.Add(new AuctionViewModel()
                    {
                        Id = item.auc.Id,
                        Name = item.auc.Name,
                        StartTime = item.auc.StartTime,
                        EndTime = item.auc.EndTime,
                        SimId = item.auc.SimId,
                        SimNumber = item.auc.SimNumber,
                        Network = item.network.NetworkName,
                        AuctionPrice = item.auc.AuctionPrice,
                        BidderNum = bidderNum,
                        Note = item.auc.Note,
                        BiddingWin = winner
                    });
                }
                return new ResponseDataViewModel<AuctionViewModel>()
                {
                    Pager = new Pager(new PagingRequestBase() { keyword = request.keyword, pageIndex = request.pageIndex, pageSize = request.pageSize }, query.Count()),
                    Data = data
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataViewModel<AuctionViewModel>();
            }
        }
        public ResponseDataViewModel<AuctionViewModel> GetMyAuction(Guid userId)
        {
            try
            {
                var myAuction = _context.AuctionUserBiddings.Where(x => x.UserId == userId).Select(x => x.AuctionId).ToList();
                if (myAuction.Count == 0) return new ResponseDataViewModel<AuctionViewModel>();
                ResponseDataViewModel<AuctionViewModel> result = new();
                var query = from auc in _context.Auctions
                            join sim in _context.SIMDetails on auc.SimId equals sim.Id
                            join network in _context.SIMNetworks on sim.SIMNetworkId equals network.Id
                            where myAuction.Contains(auc.Id)
                            orderby auc.CreateTime descending
                            select new { auc, network };
                var dataPaging = query.ToList();
                List<AuctionViewModel> data = new();
                foreach (var item in dataPaging)
                {
                    var bidderNum = _context.AuctionUserBiddings.Where(x => x.AuctionId == item.auc.Id).Count();
                    AuctionUserBiddingModel winner = new();
                    var userWin = _context.AuctionUserBiddings.Where(x => x.AuctionId == item.auc.Id).OrderByDescending(x => x.Price).FirstOrDefault();
                    if (userWin != null)
                    {
                        winner.Id = userWin.Id;
                        winner.AuctionId = userWin.AuctionId;
                        winner.Price = userWin.Price;
                        winner.UserId = userWin.UserId;
                        winner.UserName = userWin.UserName;
                    }
                    data.Add(new AuctionViewModel()
                    {
                        Id = item.auc.Id,
                        Name = item.auc.Name,
                        StartTime = item.auc.StartTime,
                        EndTime = item.auc.EndTime,
                        SimId = item.auc.SimId,
                        SimNumber = item.auc.SimNumber,
                        Network = item.network.NetworkName,
                        AuctionPrice = item.auc.AuctionPrice,
                        BidderNum = bidderNum,
                        Note = item.auc.Note,
                        BiddingWin = winner
                    });
                }
                return new ResponseDataViewModel<AuctionViewModel>()
                {
                    Pager = new Pager(new PagingRequestBase() { keyword = "", pageIndex = 0, pageSize = query.Count() }, query.Count()),
                    Data = data
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataViewModel<AuctionViewModel>();
            }
        }

        public ResponseDataModel<string> CreateAuction(AuctionModel request, Guid userId)
        {
            try
            {
                var simInfo = _context.SIMDetails.Where(x => x.SIMNumber.Replace(",", "") == request.SimNumber.Replace(",", "")).FirstOrDefault();

                if (simInfo == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Sim đấu giá không tồn tại trong hệ thống.",
                    };
                }
                var auction = _context.Auctions.FirstOrDefault(x => x.SimNumber.Replace(",", "") == request.SimNumber.Replace(",", ""));
                if (auction != null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Sim đã được đấu giá.",
                    };
                }

                //Create SPContact
                var dataNew = new Auction()
                {
                    Name = request.Name,
                    StartTime = request.StartTime,
                    EndTime = request.EndTime.AddDays(1).AddSeconds(-1),
                    SimId = simInfo.Id,
                    SimNumber = simInfo.SIMNumber ?? "",
                    AuctionPrice = request.AuctionPrice,
                    Note = request.Note,
                    CreateBy = userId,
                    UpdateBy = userId,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                };

                _context.Auctions.Add(dataNew);
                var result = _context.SaveChanges();
                //
                LogAction logAction = new LogAction()
                {
                    ActionName = "Tạo phiên đấu giá",
                    ControllerName = "",
                    CreateBy = userId,
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(request),
                    OldData = ""
                };
                _logAction.InsertLogAction(logAction);
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Tạo mới thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo phiên đấu giá.",
                };
            }
        }

        public ResponseDataModel<string> DeleteAuction(int Id, Guid userId)
        {
            try
            {
                var dataEntity = _context.Auctions.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Phiên đấu giá không tồn tại.",
                    };
                _context.Auctions.Remove(dataEntity);
                _context.SaveChanges();

                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa dữ liệu.",
                };
            }
        }

        public AuctionModel DetailAuction(int Id)
        {
            AuctionModel result = new AuctionModel();
            var dataEntity = _context.Auctions.FirstOrDefault(x => x.Id == Id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Name = dataEntity.Name;
                result.StartTime = dataEntity.StartTime;
                result.EndTime = dataEntity.EndTime;
                result.SimId = dataEntity.Id;
                result.SimNumber = dataEntity.SimNumber;
                result.AuctionPrice = dataEntity.AuctionPrice;
                result.Note = dataEntity.Note;
            }
            return result;
        }

        public ResponseDataModel<string> UpdateAuction(AuctionModel request, Guid userId)
        {
            try
            {
                var simInfo = _context.SIMDetails.Where(x => x.SIMNumber.Replace(",", "") == request.SimNumber.Replace(",", "")).FirstOrDefault();
                if (simInfo == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Sim đấu giá không tồn tại trong hệ thống.",
                    };
                }
                var dataEntity = _context.Auctions.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                }

                dataEntity.Name = request.Name;
                dataEntity.StartTime = request.StartTime;
                dataEntity.EndTime = request.EndTime;
                dataEntity.SimId = simInfo.Id;
                dataEntity.SimNumber = simInfo.SIMNumber ?? "";
                dataEntity.AuctionPrice = request.AuctionPrice;
                dataEntity.Note = request.Note;
                dataEntity.UpdateBy = userId;
                dataEntity.UpdateTime = DateTime.Now;

                _context.Auctions.Update(dataEntity);
                var result = _context.SaveChanges();
                //
                LogAction logAction = new LogAction()
                {
                    ActionName = "Sửa phiên đấu giá",
                    ControllerName = "",
                    CreateBy = userId,
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(request),
                    OldData = ""
                };
                _logAction.InsertLogAction(logAction);
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Cập nhật thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Cập nhật thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình cập nhật.",
                };
            }
        }

        public ResponseDataModel<string> CreateBiddingAuction(AuctionUserBiddingModel request)
        {
            try
            {
                var moneyInCash = _cashBook.GetMoneyInCash(request.UserId);
                var sysConfig = _context.SystemConfigs.FirstOrDefault() ?? new SystemConfig();
                if (moneyInCash < sysConfig.Auction_Deposit)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = $"Bạn cần có {sysConfig.Auction_Deposit} trong quỹ để tham gia đấu giá.",
                    };
                }
                var auction = _context.Auctions.FirstOrDefault(x => x.Id == request.AuctionId && x.StartTime < DateTime.Now && x.EndTime > DateTime.Now);

                if (auction == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Phiên đấu giá không hợp lệ.",
                    };
                }
                //Kiểm tra giá đặt với giá khởi điểm
                var minAuctionPrice = auction.AuctionPrice;
                if (request.Price <= minAuctionPrice)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Giá bạn đặt cần lớn hơn hoặc bằng giá khởi điểm",
                    };
                }
                //Kiểm tra giá đặt đã có chưa
                var biddingPrice = _context.AuctionUserBiddings.Where(x => x.AuctionId == request.AuctionId && x.Price == request.Price).FirstOrDefault();
                if (biddingPrice != null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Giá bạn chọn đã có người đặt",
                    };
                }
                //Kiểm tra thời gian đặt giá
                var lastBidding = _context.AuctionUserBiddings.Where(x => x.AuctionId == request.AuctionId).OrderBy(x => x.UpdateTime).LastOrDefault();
                if (lastBidding != null)
                {
                    var biddingDelayTime = _context.SystemConfigs.FirstOrDefault()?.Auction_WaitingTime ?? 0;
                    var delayTime = lastBidding.UpdateTime.AddSeconds(biddingDelayTime);
                    if (delayTime >= DateTime.Now)
                    {
                        return new ResponseDataModel<string>()
                        {
                            Code = "0",
                            Message = "Bạn cần chờ " + (int)(delayTime - DateTime.Now).TotalSeconds + " giây để đặt giá tiếp.",
                        };
                    }
                }

                var bidding = _context.AuctionUserBiddings.Where(x => x.AuctionId == request.AuctionId && x.UserId == request.UserId).FirstOrDefault();

                if (bidding != null)
                {
                    bidding.Price = request.Price;
                    bidding.UpdateBy = request.UserId;
                    bidding.UpdateTime = DateTime.Now;

                    _context.AuctionUserBiddings.Update(bidding);
                    _context.SaveChanges();
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Bạn đã đặt giá thành công.",
                    };
                }

                //Create
                var user = _context.Users.FirstOrDefault(x => x.Id == request.UserId);
                var dataNew = new AuctionUserBidding()
                {
                    AuctionId = request.AuctionId,
                    Price = request.Price,
                    UserId = request.UserId,
                    UserName = user.FullName,
                    CreateBy = request.UserId,
                    UpdateBy = request.UserId,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                };

                _context.AuctionUserBiddings.Add(dataNew);
                var result = _context.SaveChanges();
                ////
                //LogAction logAction = new LogAction()
                //{
                //    ActionName = "Tham gia đấu giá",
                //    ControllerName = "",
                //    CreateBy = request.UserId,
                //    CreateTime = DateTime.Now,
                //    IpAddressUser = null,
                //    NewData = JsonConvert.SerializeObject(request),
                //    OldData = ""
                //};
                //_logAction.InsertLogAction(logAction);
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Bạn đã đặt giá thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo phiên đấu giá.",
                };
            }
        }

    }
}
