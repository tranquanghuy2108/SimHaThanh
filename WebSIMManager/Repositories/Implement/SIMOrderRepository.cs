using Commons.Enums;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Newtonsoft.Json;
using Repositories.Interface;

namespace Repositories.Implement
{
    public class SIMOrderRepository : ISIMOrderRepository
    {
        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;

        public SIMOrderRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new(context);
        }

        public ResponseDataModel<int> CreateSIMOrder(SIMOrderModel request)
        {
            try
            {
                if (request.simInOrders.Count > 0)
                {
                    var simHadOrderIds = _context
                        .SIMWithOrders.Where(x => request.simInOrders.Equals(x.SimId))
                        .Select(x => x.OrderId)
                        .ToList();
                    if (simHadOrderIds.Count > 0)
                    {
                        var dataChecking = _context
                            .SIMOrders.Where(x =>
                                simHadOrderIds.Contains(x.Id)
                                && x.Status != StatusOrder.Approved
                                && x.Status != StatusOrder.Cancel
                                && x.Status != StatusOrder.Success
                                && (x.Status == StatusOrder.Order && x.TimeUnlock > DateTime.Now)
                            )
                            .FirstOrDefault();
                        if (dataChecking != null)
                        {
                            return new ResponseDataModel<int>()
                            {
                                Code = "0",
                                Message = "SIM đã có người đặt",
                            };
                        }
                    }
                    var userBuy = _context.Users.FirstOrDefault(x => x.Id == request.UserBuyId);
                    //Create SIMOrder
                    var userByName = userBuy?.FullName ?? "";
                    if (!string.IsNullOrEmpty(request.Name))
                    {
                        userByName = request.Name;
                    }
                    var dataNew = new SIMOrder()
                    {
                        Address = request.Address,
                        UserBuyId = request.UserBuyId,
                        Name = userByName,
                        PhoneNum = request.PhoneNum,
                        PriceOrder = request.PriceOrder ?? 0,
                        Discount = request.Discount,
                        SIMEmbryoFee = request.SIMEmbryoFee,
                        SIMServiceFee = request.SIMServiceFee,
                        Note = request.Note ?? "",
                        Status = StatusOrder.Order,
                        CreateBy =
                            request.UserId ?? new Guid("C09B6C9B-3405-4ABB-B39F-2FAA705226D8"),
                        UpdateBy =
                            request.UserId ?? new Guid("C09B6C9B-3405-4ABB-B39F-2FAA705226D8"),
                        PIC = request.UserId ?? new Guid("C09B6C9B-3405-4ABB-B39F-2FAA705226D8"),
                        CreateTime = DateTime.Now,
                        UpdateTime = DateTime.Now,
                        TimeUnlock = DateTime.Now.AddHours(24),
                        ContactId = request.ContactId,
                        PriceOfSim = request.PriceOfSim,
                        TypePriceSimOrder = request.TypePriceSimOrder,
                        //
                        PayOrderType = request.PaymentType,
                        InstallmentPeriod = request.InstallmentPeriod,
                        DateOfPayment = DateTime.Now.Day,
                        InstallmentEndDate = DateTime.Now.AddMonths(request.InstallmentPeriod),
                        DownPayment = request.DownPayment ?? 0,
                        InstallmentPayment = request.InstallmentPayment ?? 0,
                        MonthlyInstallmentPayment = request.MonthlyInstallmentPayment ?? 0,
                        InterestRate = request.InterestRate ?? 0,
                    };

                    _context.SIMOrders.Add(dataNew);
                    var result = _context.SaveChanges();

                    foreach (var simInOrder in request.simInOrders)
                    {
                        _context.SIMWithOrders.Add(
                            new SIMWithOrder()
                            {
                                OrderId = dataNew.Id,
                                SimId = simInOrder.simId,
                                UsingEsim = simInOrder.usingEsim,
                            }
                        );
                    }
                    _context.SaveChanges();

                    //Ghi log
                    LogAction logAction = new LogAction()
                    {
                        ActionName = "Tạo đơn hỏi mua SIM",
                        ControllerName = "",
                        CreateBy = request.UserId ?? new Guid(),
                        CreateTime = DateTime.Now,
                        IpAddressUser = null,
                        NewData = JsonConvert.SerializeObject(request),
                        OldData = "",
                    };
                    _logAction.InsertLogAction(logAction);
                    if (result > 0)
                    {
                        return new ResponseDataModel<int>()
                        {
                            Code = "1",
                            Message = "Tạo mới thành công.",
                            Data = dataNew.Id,
                        };
                    }
                    else
                    {
                        return new ResponseDataModel<int>()
                        {
                            Code = "0",
                            Message = "Tạo mới thất bại.",
                        };
                    }
                }
                else
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "0",
                        Message =
                            "Không có sim phù hợp với đơn bạn tạo. Liên hệ Admin để được hỗ trợ.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<int>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo giỏ hàng.",
                };
            }
        }

        public ResponseDataModel<string> DeleteSIMOrder(int Id, string userId)
        {
            try
            {
                var dataEntity = _context.SIMOrders.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                var oldData = JsonConvert.SerializeObject(dataEntity);
                _context.SIMOrders.Remove(dataEntity);
                var simWithOrder = _context.SIMWithOrders.Where(x => x.OrderId == Id);
                _context.SIMWithOrders.RemoveRange(simWithOrder);
                _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa đơn hỏi mua SIM",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = "",
                    OldData = oldData,
                };
                _logAction.InsertLogAction(logAction);
                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa dữ liệu thành công.",
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

        public SIMOrderModel GetSIMOrder(int Id)
        {
            SIMOrderModel result = new SIMOrderModel();
            var dataEntity = _context.SIMOrders.FirstOrDefault(x => x.Id == Id);
            var simInOrder = _context.SIMWithOrders.Where(x => x.OrderId == Id).ToList();
            List<SimInOrder> simInOrders = new();
            foreach (var sim in simInOrder)
            {
                simInOrders.Add(
                    new SimInOrder() { simId = sim.SimId, usingEsim = sim.UsingEsim ?? false }
                );
            }
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Name = dataEntity.Name;
                result.PhoneNum = dataEntity.PhoneNum;
                result.UserBuyId = dataEntity.UserBuyId;
                result.Address = dataEntity.Address ?? "";
                result.simInOrders = simInOrders;
                result.Status = dataEntity.Status;
                result.PriceOrder = dataEntity.PriceOrder;
                result.SIMEmbryoFee = dataEntity.SIMEmbryoFee;
                result.SIMServiceFee = dataEntity.SIMServiceFee;
                result.PaymentType = dataEntity.PayOrderType;
                result.UpdateBy = dataEntity.UpdateBy;
                result.Note = dataEntity.Note;
                result.ContactId = dataEntity.ContactId;
                result.PriceOfSim = dataEntity.PriceOfSim;
                result.TypePriceSimOrder = dataEntity.TypePriceSimOrder;
                result.Discount = dataEntity.Discount;

                result.InstallmentPeriod = dataEntity.InstallmentPeriod;
                result.DateOfPayment = dataEntity.DateOfPayment;
                result.InstallmentEndDate = dataEntity.InstallmentEndDate;
                result.DownPayment = dataEntity.DownPayment;
                result.InstallmentPayment = dataEntity.InstallmentPayment;
                result.MonthlyInstallmentPayment = dataEntity.MonthlyInstallmentPayment;
                result.InterestRate = dataEntity.InterestRate;
            }
            return result;
        }

        public ResponseDataViewModel<SIMOrderViewModel> SearcSIMOrderPaging(
            OrderFilterRequest request
        )
        {
            UpdateOrderOverTime();
            var query =
                from so in _context.SIMOrders
                //join swo in _context.SIMWithOrders on so.Id equals swo.OrderId
                //join s in _context.SIMDetails on swo.SimId equals s.Id
                //where so.Status == request.statusOrder
                orderby so.CreateTime descending
                select new { so };

            if (request.agents.Count > 0)
            {
                query = query.Where(x => request.agents.Contains(x.so.UserBuyId.ToString()));
            }
            if (request.isMyOrder)
            {
                query = query.Where(x => x.so.PIC.ToString() == request.userId);
            }
            //if(request.statusOrder != null)
            //{
            //    query = query.Where(x => x.so.Status == request.statusOrder);
            //}
            var dataPaging = query
                .Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .ToList();
            var data = new List<SIMOrderViewModel>();
            foreach (var item in dataPaging)
            {
                var pic = _context.Users.FirstOrDefault(x => x.Id == item.so.PIC)?.FullName;
                var userBuy = _context.Users.FirstOrDefault(y => y.Id == item.so.UserBuyId);
                var sims = (
                    from sim in _context.SIMDetails
                    join simwo in _context.SIMWithOrders on sim.Id equals simwo.SimId
                    where simwo.OrderId == item.so.Id
                    select sim
                ).ToList();

                var productTypeIds = sims.Select(x => x.ProductTypeId).ToList();
                var productTypes = _context
                    .ProductTypes.Where(x => productTypeIds.Contains(x.Id))
                    .Select(x => x.Name)
                    .ToList();
                var PaymentType = "";
                switch (item.so.PayOrderType)
                {
                    case Commons.Enums.PaymentType.COD:
                        PaymentType = "Tiền mặt";
                        break;
                    case Commons.Enums.PaymentType.Online:
                        PaymentType = "Chuyển khoản";
                        break;
                    case Commons.Enums.PaymentType.Company:
                        PaymentType = "Xuất hóa đơn Cty";
                        break;
                    case Commons.Enums.PaymentType.Installment:
                        PaymentType = "Trả góp";
                        break;
                }
                var contact = _context.SupportContacts.FirstOrDefault(x =>
                    x.Id == item.so.ContactId
                );
                var userByName = userBuy?.FullName ?? "";
                if (!string.IsNullOrEmpty(item.so.Name))
                {
                    userByName = item.so.Name;
                }
                data.Add(
                    new SIMOrderViewModel()
                    {
                        Id = item.so.Id,
                        //SIMId = item.s.Id,
                        Name = item.so.Name ?? "",
                        PhoneNum = item.so.PhoneNum ?? "",
                        priceOrder = item.so.PriceOrder.ToString("#,##0.##"),
                        simEmbryoFee = item.so.SIMEmbryoFee.ToString("#,##0.##"),
                        simServiceFee = item.so.SIMServiceFee.ToString("#,##0.##"),
                        discount = "",
                        priceOfSim = sims.Select(x => x.SIMPrice).Sum().ToString("#,##0.##"),
                        Address = item.so.Address ?? "",
                        SIMNumber = string.Join("\n", sims.Select(x => x.SIMNumber).ToList()) ?? "",
                        CreateTime = item.so.CreateTime.ToString("HH:mm dd.MM.yyyy"),
                        PIC = pic ?? "",
                        Status = Enum.GetName(typeof(StatusOrder), item.so.Status),
                        Note = item.so.Note ?? "",
                        payOrderType = PaymentType,
                        Contact = contact?.Name ?? "",
                        ProductType = string.Join("\n", productTypes) ?? "",
                    }
                );
            }

            //
            return new ResponseDataViewModel<SIMOrderViewModel>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
                    {
                        keyword = "",
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    query.Count()
                ),
                Data = data,
            };
        }

        public ResponseDataViewModel<SIMOrderViewModel> GetSIMOrderPaging(GetPagingRequest request)
        {
            UpdateOrderOverTime();
            var query =
                from so in _context.SIMOrders
                join swo in _context.SIMWithOrders on so.Id equals swo.OrderId
                join s in _context.SIMDetails on swo.SimId equals s.Id
                where s.SIMNumber.Contains(request.keyword)
                orderby so.CreateTime descending
                select new { so, s };

            var dataEntity = _context.SIMOrders; //.Where(x => x.Name.Contains(request.keyword));
            var dataPaging = query
                .Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .ToList();
            var data = new List<SIMOrderViewModel>();
            foreach (var item in dataPaging)
            {
                var pic = _context.Users.FirstOrDefault(x => x.Id == item.so.PIC)?.FullName;
                data.Add(
                    new SIMOrderViewModel()
                    {
                        Id = item.so.Id,
                        SIMId = item.s.Id,
                        //Name = item.so.Name ?? "",
                        //PhoneNum = item.so.PhoneNum ?? "",
                        priceOrder = item.s.SIMPrice.ToString("#,##0.##"),
                        Address = item.so.Address ?? "",
                        SIMNumber = item.s.SIMNumber ?? "",
                        CreateTime = item.so.CreateTime.ToString("HH:mm dd.MM.yyyy"),
                        PIC = pic ?? "",
                        Status = Enum.GetName(typeof(StatusOrder), item.so.Status),
                        Note = item.so.Note ?? "",
                    }
                );
            }

            //
            return new ResponseDataViewModel<SIMOrderViewModel>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
                    {
                        keyword = request.keyword,
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    dataEntity.Count()
                ),
                Data = data,
            };
        }

        public ResponseDataViewModel<SIMOrderViewModel> GetSIMOrderOnHomePaging(
            GetPagingRequest request
        )
        {
            UpdateOrderOverTime();
            var query =
                from so in _context.SIMOrders
                join swo in _context.SIMWithOrders on so.Id equals swo.OrderId
                join s in _context.SIMDetails on swo.SimId equals s.Id
                join u in _context.Users on so.UserBuyId equals u.Id
                where
                    s.SIMNumber.Contains(request.keyword)
                    && so.Status != StatusOrder.Cancel
                    && u.IsAgent != true
                    && u.IsConsignmentAgent != true
                orderby so.CreateTime descending
                select new { so, s };

            var dataEntity = _context.SIMOrders; //.Where(x => x.Name.Contains(request.keyword));
            var dataPaging = query
                .Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .ToList();
            var data = new List<SIMOrderViewModel>();
            foreach (var item in dataPaging)
            {
                data.Add(
                    new SIMOrderViewModel()
                    {
                        SIMId = item.s.Id,
                        Name = item.so.Name,
                        PhoneNum = item.so.PhoneNum,
                        Address = item.so.Address,
                        SIMNumber = item.s.SIMNumber,
                        CreateTime = item.so.CreateTime.ToString("HH:mm dd.MM.yyyy"),
                        Status = Enum.GetName(typeof(StatusOrder), item.so.Status),
                    }
                );
            }

            //
            return new ResponseDataViewModel<SIMOrderViewModel>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
                    {
                        keyword = request.keyword,
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    dataEntity.Count()
                ),
                Data = data,
            };
        }

        public ResponseDataModel<string> UpdateSIMOrder(SIMOrderModel request)
        {
            try
            {
                var dataEntity = _context.SIMOrders.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Đơn hàng không tồn tại.",
                    };
                }
                var oldData = JsonConvert.SerializeObject(dataEntity);

                var userBuy = _context.Users.FirstOrDefault(x => x.Id == request.UserBuyId);

                dataEntity.Address = request.Address;
                dataEntity.PhoneNum = request.PhoneNum;
                dataEntity.UserBuyId = request.UserBuyId;
                dataEntity.Name = userBuy?.FullName ?? "";
                dataEntity.Note = request.Note ?? "";
                dataEntity.PriceOrder = request.PriceOrder ?? 0;
                dataEntity.SIMEmbryoFee = request.SIMEmbryoFee;
                dataEntity.SIMServiceFee = request.SIMServiceFee;
                dataEntity.UpdateBy = request.UpdateBy ?? new Guid();
                dataEntity.UpdateTime = DateTime.Now;
                dataEntity.PayOrderType = request.PaymentType;
                dataEntity.ContactId = request.ContactId;
                dataEntity.PriceOfSim = request.PriceOfSim;
                dataEntity.TypePriceSimOrder = request.TypePriceSimOrder;
                dataEntity.Discount = request.Discount;
                //
                dataEntity.InstallmentPeriod = request.InstallmentPeriod;
                dataEntity.DownPayment = request.DownPayment ?? 0;
                dataEntity.InstallmentPayment = request.InstallmentPayment ?? 0;
                dataEntity.MonthlyInstallmentPayment = request.MonthlyInstallmentPayment ?? 0;
                dataEntity.InterestRate = request.InterestRate ?? 0;

                _context.SIMOrders.Update(dataEntity);

                var simInOrders = _context.SIMWithOrders.Where(x => x.OrderId == request.Id);
                foreach (var simInOrder in simInOrders)
                {
                    simInOrder.UsingEsim = request
                        .simInOrders.FirstOrDefault(x => x.simId == simInOrder.SimId)
                        ?.usingEsim;
                    _context.SIMWithOrders.Update(simInOrder);
                }
                var result = _context.SaveChanges();

                var gdns = _context.GoodsDeliveryNoteOfSim.FirstOrDefault(x =>
                    x.Id == dataEntity.debtId
                );
                if (gdns != null)
                {
                    gdns.CustomerId = dataEntity.UserBuyId;
                    gdns.CustomerPhone = dataEntity.PhoneNum;
                    gdns.CustomerAddress = dataEntity.Address ?? "";
                    gdns.CustomerName = userBuy?.FullName ?? "";

                    _context.GoodsDeliveryNoteOfSim.Update(gdns);
                    _context.SaveChanges();
                }

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Cập nhật đơn hỏi mua SIM",
                    ControllerName = "",
                    CreateBy = request.UpdateBy ?? new Guid(),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(request),
                    OldData = oldData,
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
                    Message = "Có lỗi trong quá trình cập nhật đơn mua.",
                };
            }
        }

        public ResponseDataModel<string> UpdateStatusOrder(
            StatusOrder status,
            string orderIds,
            string userId
        )
        {
            try
            {
                var dataEntity = _context.SIMOrders.Where(x =>
                    orderIds.Contains(x.Id.ToString()) && x.Status == StatusOrder.Order
                );
                if (dataEntity == null || dataEntity.Count() == 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Đơn hàng không tồn tại hoặc đã được xử lý.",
                    };
                }
                var updateUser = new Guid();

                foreach (var order in dataEntity)
                {
                    if (!String.IsNullOrEmpty(userId))
                    {
                        updateUser = new Guid(userId);
                    }
                    else
                    {
                        updateUser = order.CreateBy;
                    }
                    if (order.TimeUnlock >= DateTime.Now)
                    {
                        order.Status = status;
                        order.UpdateBy = updateUser;
                        order.UpdateTime = DateTime.Now;
                    }
                    else
                    {
                        order.Status = StatusOrder.Cancel;
                        order.UpdateBy = updateUser;
                        order.UpdateTime = DateTime.Now;
                    }
                }

                _context.SIMOrders.UpdateRange(dataEntity);

                var result = _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Cập nhật trạng thái đơn hỏi mua SIM",
                    ControllerName = "",
                    CreateBy = updateUser,
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = orderIds + Enum.GetName(typeof(StatusOrder), status),
                    OldData = orderIds + Enum.GetName(typeof(StatusOrder), StatusOrder.Order),
                };
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
                        Code = "-1",
                        Message = "Cập nhật thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình cập nhật đơn mua.",
                };
            }
        }

        public ResponseDataViewModel<SIMOrderViewAPIModel> GetSIMOrderApp(Guid userId)
        {
            UpdateOrderOverTime();
            var query = _context.SIMOrders.Where(x => x.CreateBy == userId).ToList();
            var user = _context.Users.FirstOrDefault(x => x.Id == userId);
            var dataPaging = query.ToList();
            var data = new List<SIMOrderViewAPIModel>();
            foreach (var item in dataPaging)
            {
                var simIdsInOrder = _context
                    .SIMWithOrders.Where(x => x.OrderId == item.Id)
                    .Select(x => x.SimId)
                    .ToList();
                var simInOrder = _context
                    .SIMDetails.Where(x => simIdsInOrder.Contains(x.Id))
                    .ToList();
                List<SimInfoInOrderAPIViewModel> simInfos = new();
                foreach (var sim in simInOrder)
                {
                    simInfos.Add(
                        new SimInfoInOrderAPIViewModel()
                        {
                            Id = sim.Id,
                            SimNumber = sim.SIMNumber ?? "",
                            SimPrice = sim.SIMPrice,
                        }
                    );
                }

                data.Add(
                    new SIMOrderViewAPIModel()
                    {
                        Id = item.Id,
                        Name = user?.FullName ?? "",
                        PhoneNum = user?.PhoneNumber ?? "",
                        Address = item.Address ?? "",
                        CreateTime = item.CreateTime.ToString("HH:mm dd.MM.yyyy"),
                        Status = Enum.GetName(typeof(StatusOrder), item.Status),
                        priceOrder = item.PriceOrder,
                        priceOfSim = item.PriceOfSim,
                        DateOfPayment = item.DateOfPayment,
                        discount = item.Discount ?? 0,
                        DownPayment = item.DownPayment,
                        InstallmentEndDate = item.InstallmentEndDate,
                        InstallmentPayment = item.InstallmentPayment,
                        InstallmentPeriod = item.InstallmentPeriod,
                        InterestRate = item.InterestRate,
                        MonthlyInstallmentPayment = item.MonthlyInstallmentPayment,
                        payOrderType =
                            item.PayOrderType == PaymentType.Installment ? "Trả góp" : "Trực tiếp",
                        SimInfos = simInfos,
                    }
                );
            }

            //
            return new ResponseDataViewModel<SIMOrderViewAPIModel>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
                    {
                        keyword = "",
                        pageIndex = 1,
                        pageSize = dataPaging.Count(),
                    },
                    dataPaging.Count()
                ),
                Data = data,
            };
        }

        public AgentChangeResModel GetDiscountOfUser(string userId, int price)
        {
            var userInfo = _context.Users.FirstOrDefault(x => x.Id.ToString() == userId);
            AgentChangeResModel agentChangeResModel = new AgentChangeResModel()
            {
                phoneNumber = userInfo?.PhoneNumber ?? "",
                address = userInfo?.Address ?? "",
                discount = 0,
                priceWithDiscount = price,
            };
            var agentGroupOfUser = _context.CollaboratorsGroupUsers.FirstOrDefault(x =>
                x.UserId.ToString() == userId
            );
            if (agentGroupOfUser != null)
            {
                var discountData = _context.Discounts.FirstOrDefault(x =>
                    x.CollaboratorsGroupId == agentGroupOfUser.CollaboratorsGroupId
                    && x.PriceFrom <= price
                    && x.PriceTo >= price
                );
                var discount = discountData?.DiscountPer ?? 0;
                agentChangeResModel.discount = discount;
                agentChangeResModel.priceWithDiscount = price - price * discount / 100;
            }

            return agentChangeResModel;
        }

        public ResponseDataModel<bool> CheckListOrderIsOneAgent(List<int> orderIds)
        {
            var lstAgentOfOrders = _context
                .SIMOrders.Where(x => orderIds.Contains(x.Id))
                .Select(x => x.UserBuyId)
                .ToList();
            lstAgentOfOrders = lstAgentOfOrders.Distinct().ToList();
            if (lstAgentOfOrders.Count == 1)
            {
                return new ResponseDataModel<bool>()
                {
                    Code = "1",
                    Message = "Đơn hàng cùng 1 KH/Đại lý",
                    Data = true,
                };
            }
            else
            {
                return new ResponseDataModel<bool>()
                {
                    Code = "1",
                    Message = "Đơn hàng không cùng 1 KH/Đại lý",
                    Data = false,
                };
            }
        }

        public ResponseDataModel<string> CheckListOrderIsAvalible(List<int> orderIds)
        {
            var orderIdLst = _context
                .SIMOrders.Where(x =>
                    orderIds.Contains(x.Id)
                    && x.Status == StatusOrder.Order
                    && x.TimeUnlock >= DateTime.Now
                )
                .Select(x => x.Id)
                .ToList();
            orderIdLst = orderIdLst.Distinct().ToList();
            if (orderIdLst.Count == 0)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "0",
                    Message = "Đơn hàng không tồn tại hoặc đã được xử lý",
                    Data = "",
                };
            }
            else
            {
                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Đơn hàng khả dụng",
                    Data = string.Join(',', orderIdLst),
                };
            }
        }

        public DataDiscountOfDebt GetOrderInfoInDebt(string orderIds)
        {
            DataDiscountOfDebt orderInfoInDebts = new();
            var orderIdsArr = orderIds.Split(',');
            if (orderIdsArr.Length > 0)
            {
                var agentId = _context
                    .SIMOrders.FirstOrDefault(x => orderIdsArr.Contains(x.Id.ToString()))
                    .UserBuyId;
                var orders = _context.SIMOrders.Where(x => orderIdsArr.Contains(x.Id.ToString()));
                var simIds = _context
                    .SIMWithOrders.Where(x => orderIdsArr.Contains(x.OrderId.ToString()))
                    .Select(x => x.SimId)
                    .ToList();
                var sims = _context.SIMDetails.Where(x => simIds.Contains(x.Id)).ToList();
                orderInfoInDebts.agentId = agentId;
                orderInfoInDebts.discount = orders.FirstOrDefault().Discount ?? 0;
                orderInfoInDebts.contact =
                    _context
                        .SupportContacts?.FirstOrDefault(x =>
                            x.Id == orders.FirstOrDefault().ContactId
                        )
                        ?.Name ?? "";
                orderInfoInDebts.priceOrder = orders.Sum(x => x.PriceOrder);
                orderInfoInDebts.priceOfSim = orders.Sum(x => x.PriceOfSim);
                orderInfoInDebts.simInfoInDebts = new();
                orderInfoInDebts.orderInDebts = new();
                foreach (var order in orders.ToList())
                {
                    SIMOrderModel model = new SIMOrderModel();
                    model.Id = order.Id;
                    model.Address = order.Address ?? "";
                    model.PhoneNum = order.PhoneNum ?? "";
                    model.UserBuyId = order.UserBuyId;
                    model.Note = order.Note ?? "";
                    model.PriceOrder = order.PriceOrder;
                    model.SIMEmbryoFee = order.SIMEmbryoFee;
                    model.SIMServiceFee = order.SIMServiceFee;
                    model.PaymentType = order.PayOrderType;
                    model.InstallmentPeriod = order.InstallmentPeriod;
                    model.DateOfPayment = order.DateOfPayment;
                    model.InstallmentEndDate = order.InstallmentEndDate;
                    model.DownPayment = order.DownPayment;
                    model.InstallmentPayment = order.InstallmentPayment;
                    model.MonthlyInstallmentPayment = order.MonthlyInstallmentPayment;
                    model.InterestRate = order.InterestRate;
                    model.ContactId = order.ContactId;

                    orderInfoInDebts.orderInDebts.Add(model);
                }
                int idx = 0;
                foreach (var item in sims)
                {
                    var simType = (
                        from t in _context.TypeOfSIMs
                        join st in _context.SIMTypes on t.Id equals st.TypeId
                        where st.SimId == item.Id
                        select t.Name
                    )
                        .Distinct()
                        .ToList();
                    var owner = _context.Users.FirstOrDefault(x => x.Id == item.Owner)?.FullName;
                    var productType = _context
                        .ProductTypes.FirstOrDefault(x => x.Id == item.ProductTypeId)
                        ?.Name;
                    var status = "Sẵn sàng";
                    var simorder = (
                        from order in _context.SIMOrders
                        join swoder in _context.SIMWithOrders on order.Id equals swoder.OrderId
                        where swoder.SimId == item.Id
                        select order
                    ).FirstOrDefault();
                    if (simorder != null)
                    {
                        if (
                            simorder.Status == StatusOrder.Order
                                && simorder.TimeUnlock >= DateTime.Now
                            || simorder.Status == StatusOrder.Success
                            || simorder.Status == StatusOrder.WaitingApproved
                        )
                        {
                            status = "Đã có người đặt";
                        }
                    }
                    var network = _context.SIMNetworks.FirstOrDefault(x =>
                        x.Id == item.SIMNetworkId
                    );
                    idx++;
                    orderInfoInDebts.simInfoInDebts.Add(
                        new SIMViewModel()
                        {
                            stt = idx,
                            Id = item.Id,
                            SIMImgUrl = item.SIMImgUrl,
                            Network = network?.NetworkName ?? "",
                            Description = item.Description,
                            Number = item.SIMNumber,
                            Seria = item.SIMSeriaNumber ?? "",
                            Owner = owner ?? "",
                            ProductType = productType ?? "",
                            Price = item.SIMPrice,
                            SIMEmbryoFee = item.SIMEmbryoFee,
                            SIMServiceFee = item.SIMServiceFee,
                            SIMType = simType,
                            Status = status,
                        }
                    );
                }
            }
            return orderInfoInDebts;
        }

        public List<SelectListItem> GetFormOfDeliveryForComb()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.FormOfDeliveries.ToList();
            foreach (var item in data)
            {
                selectListItems.Add(
                    new SelectListItem
                    {
                        Text = item.Name + " (" + item.Description + ")",
                        Value = item.Id.ToString(),
                    }
                );
            }
            return selectListItems;
        }

        public List<InstallmentSimViewModel> GetInstallmentOrder(Guid userId)
        {
            List<InstallmentSimViewModel> installmentSim = new();
            var orders =
                from so in _context.SIMOrders
                join ub in _context.Users on so.UserBuyId equals ub.Id
                join swo in _context.SIMWithOrders on so.Id equals swo.OrderId
                join s in _context.SIMDetails on swo.SimId equals s.Id
                where so.UserBuyId == userId && so.PayOrderType == PaymentType.Installment
                select new
                {
                    so,
                    ub,
                    s,
                };

            foreach (var order in orders)
            {
                InstallmentSimViewModel installment = new();
                installment.SimNumber = order.s.SIMNumber;
                installment.OrderId = order.so.Id;
                installment.OrderPrice = order.so.PriceOrder;
                installment.UserBuy = order.ub.FullName;
                installment.InstallmentPeriod = order.so.InstallmentPeriod;
                installment.DateOfPayment = order.so.DateOfPayment;
                installment.InstallmentEndDate = order.so.InstallmentEndDate;
                installment.DownPayment = order.so.DownPayment;
                installment.InstallmentPayment = order.so.InstallmentPayment;
                installment.MonthlyInstallmentPayment = order.so.MonthlyInstallmentPayment;
                installment.InterestRate = order.so.InterestRate;
                installment.Note = order.so.Note;
                installment.ApprovedStatus =
                    Enum.GetName(typeof(StatusOrder), order.so.Status) ?? "";
                installmentSim.Add(installment);
            }
            return installmentSim;
        }

        public ResponseDataViewModel<SIMOrderViewModel> GetOrderForAskSim(GetPagingRequest request)
        {
            UpdateOrderOverTime();
            var query =
                from so in _context.SIMOrders
                orderby so.Status, so.CreateTime descending
                select so;

            var dataPaging = query
                .Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .ToList();
            var data = new List<SIMOrderViewModel>();
            foreach (var simOrder in dataPaging)
            {
                var payOrderType = "";
                switch (simOrder.PayOrderType)
                {
                    case PaymentType.COD:
                        payOrderType = "Thanh toán tiền mặt";
                        break;
                    case PaymentType.Online:
                        payOrderType = "Thanh toán online";
                        break;
                    case PaymentType.Company:
                        payOrderType = "Xuất hóa đơn công ty";
                        break;
                    case PaymentType.Installment:
                        payOrderType = "Thanh toán trả góp";
                        break;
                }
                var simWithOrder = _context.SIMWithOrders.Where(x => x.OrderId == simOrder.Id);
                var simInOrderInfos = _context
                    .SIMDetails.Where(x =>
                        simWithOrder.Select(x => x.SimId).ToList().Contains(x.Id)
                    )
                    .ToList();
                var productTypeIds = simInOrderInfos.Select(x => x.ProductTypeId).ToList();
                var productTypes = _context
                    .ProductTypes.Where(x => productTypeIds.Contains(x.Id))
                    .Select(x => x.Name)
                    .ToList();
                var contact = _context.SupportContacts.FirstOrDefault(x =>
                    x.Id == simOrder.ContactId
                );
                var pic = _context.Users.FirstOrDefault(x => x.Id == simOrder.PIC);
                data.Add(
                    new SIMOrderViewModel()
                    {
                        Id = simOrder.Id,
                        Address = simOrder.Address ?? "",
                        CreateTime = simOrder.CreateTime.ToString("HH:mm dd.MM.yyyy"),
                        Name = simOrder.Name ?? "",
                        Note = simOrder.Note,
                        payOrderType = payOrderType,
                        PhoneNum = simOrder.PhoneNum ?? "",
                        PIC = pic?.FullName ?? "",
                        priceOrder = simOrder.PriceOrder.ToString("#,##0.##"),
                        priceOfSim = simOrder.PriceOfSim.ToString("#,##0.##"),
                        SIMNumber = string.Join(
                            "<br/>",
                            simInOrderInfos.Select(x => x.SIMNumber).ToList()
                        ),
                        Status = Enum.GetName(typeof(StatusOrder), simOrder.Status) ?? "",
                        SimPosition = string.Join(
                            "<br/>",
                            simInOrderInfos.Select(x => x.Position).ToList()
                        ),
                        seria = string.Join(
                            "<br/>",
                            simInOrderInfos.Select(x => x.SIMSeriaNumber).ToList()
                        ),
                        Contact = contact?.Name ?? "",
                        ProductType = string.Join("<br/>", productTypes),
                    }
                );
            }

            //
            return new ResponseDataViewModel<SIMOrderViewModel>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
                    {
                        keyword = request.keyword,
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    query.Count()
                ),
                Data = data,
            };
        }

        private void UpdateOrderOverTime()
        {
            var orders = _context
                .SIMOrders.Where(x => x.Status == StatusOrder.Order && x.TimeUnlock < DateTime.Now)
                .ToList();
            if (orders.Count() > 0)
            {
                foreach (var order in orders)
                {
                    order.Status = StatusOrder.Cancel;
                }
                _context.UpdateRange(orders);
                _context.SaveChanges();
            }
        }

        public List<ProductTypeOfSimData> GetListSimData()
        {
            List<ProductTypeOfSimData> simDataLst = new();
            var productTypes = _context
                .ProductTypes.Where(x => x.IsSimData && !x.IsTouristSim)
                .ToList();
            //var simLst = _context.SIMDetails.ToList();
            foreach (var item in productTypes)
            {
                //var amount = simLst.Where(x => x.ProductTypeId == item.Id).Count();
                simDataLst.Add(
                    new ProductTypeOfSimData
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Summary = item.Summary,
                        Description = item.Description,
                        Price = item.DefaulPrice,
                        CountryId = item.CountryId,
                        //Amount = amount,
                        IsSimData = item.IsSimData,
                        IsTouristSim = item.IsTouristSim,
                    }
                );
            }
            return simDataLst;
        }

        public List<ProductTypeOfSimData> GetListTouristSim()
        {
            List<ProductTypeOfSimData> touristSimLst = new();
            var productTypes = _context.ProductTypes.Where(x => x.IsTouristSim).ToList();
            //var simLst = _context.SIMDetails.ToList();
            foreach (var item in productTypes)
            {
                //var amount = simLst.Where(x => x.ProductTypeId == item.Id).Count();
                touristSimLst.Add(
                    new ProductTypeOfSimData
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Summary = item.Summary,
                        Description = item.Description,
                        Price = item.DefaulPrice,
                        CountryId = item.CountryId,
                        //Amount = amount,
                        IsSimData = item.IsSimData,
                        IsTouristSim = item.IsTouristSim,
                    }
                );
            }
            return touristSimLst;
        }
    }
}
