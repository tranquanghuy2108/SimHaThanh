using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Commons.Enums;
using Commons.Helper;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Microsoft.AspNetCore.Mvc;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Newtonsoft.Json;
using Repositories.Interface;
using Telegram.Bot.Types.Payments;

namespace Repositories.Implement
{
    public class GoodsDeliveryNoteOfSimRepository : IGoodsDeliveryNoteOfSimRepository
    {
        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;

        public GoodsDeliveryNoteOfSimRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new(context);
        }

        public ResponseDataModel<string> Approved(
            string goodsDeliveryNoteOfSimIds,
            ApprovedStatus status,
            string userId
        )
        {
            try
            {
                var dataAppr = _context
                    .GoodsDeliveryNoteOfSim.Where(x =>
                        goodsDeliveryNoteOfSimIds.Contains(x.Id.ToString())
                        && (
                            x.approvedStatus == ApprovedStatus.Waiting
                            || status == ApprovedStatus.Reject
                        )
                    )
                    .ToList();
                if (dataAppr == null || dataAppr.Count == 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Công nợ không tồn tại hoặc đã được duyệt.",
                    };
                }
                foreach (var data in dataAppr)
                {
                    data.UpdateBy = new Guid(userId);
                    data.UpdateTime = DateTime.Now;
                    data.ApprovedBy = new Guid(userId);
                    data.ApprovedTime = DateTime.Now;
                    data.approvedStatus = status;

                    var dataBank = _context.DebtBanks.FirstOrDefault(x => x.DebtCode == data.Code);
                    if (dataBank != null)
                    {
                        dataBank.approvedBy = new Guid(userId);
                        dataBank.approvedTime = DateTime.Now;
                        dataBank.approvedStatus = status;
                        _context.DebtBanks.Update(dataBank);
                    }
                    var dataShipping = _context.DebtShippings.FirstOrDefault(x =>
                        x.DebtCode == data.Code
                    );
                    if (dataShipping != null)
                    {
                        dataShipping.approvedBy = new Guid(userId);
                        dataShipping.approvedTime = DateTime.Now;
                        dataShipping.approvedStatus = status;
                        _context.DebtShippings.Update(dataShipping);
                    }
                    var dataStaff = _context.DebtStaffs.FirstOrDefault(x =>
                        x.DebtCode == data.Code
                    );
                    if (dataStaff != null)
                    {
                        dataStaff.approvedBy = new Guid(userId);
                        dataStaff.approvedTime = DateTime.Now;
                        dataStaff.approvedStatus = status;
                        _context.DebtStaffs.Update(dataStaff);
                    }
                    var dataAgents = _context.DebtAgents.Where(x => x.DebtCode == data.Code);
                    foreach (var agent in dataAgents)
                    {
                        agent.approvedBy = new Guid(userId);
                        agent.approvedTime = DateTime.Now;
                        agent.approvedStatus = status;
                        _context.DebtAgents.Update(agent);
                    }
                }
                var listDataAprrIds = dataAppr.Select(x => x.Id).ToList();
                var orders = _context.SIMOrders.Where(x => listDataAprrIds.Contains(x.debtId ?? 0));
                foreach (var order in orders)
                {
                    order.UpdateBy = new Guid(userId);
                    order.UpdateTime = DateTime.Now;
                    var statusOrder = StatusOrder.Approved;
                    if (status == ApprovedStatus.Reject)
                        statusOrder = StatusOrder.Cancel;
                    order.Status = statusOrder;
                }
                _context.SIMOrders.UpdateRange(orders);
                _context.GoodsDeliveryNoteOfSim.UpdateRange(dataAppr);
                var result = _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Approved PXSim",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData =
                        "PXSim có ID: "
                        + goodsDeliveryNoteOfSimIds
                        + " status "
                        + Enum.GetName(typeof(ApprovedStatus), status),
                    OldData =
                        "PXSim có ID: "
                        + goodsDeliveryNoteOfSimIds
                        + " status "
                        + Enum.GetName(typeof(ApprovedStatus), dataAppr[0].approvedStatus),
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

        public ResponseDataModel<string> Create(GoodsDeliveryNoteOfSimModel request, string userId)
        {
            try
            {
                var prefix = "PXSim";
                var lastGDNS = _context
                    .GoodsDeliveryNoteOfSim.OrderByDescending(x => x.Id)
                    .FirstOrDefault();
                var debtCodeNum = 0;
                if (lastGDNS != null)
                {
                    debtCodeNum = lastGDNS.Id;
                }
                var debtCode = prefix + (debtCodeNum + 1).ToString("000000");
                //Create SPContact
                var customer = _context.Users.FirstOrDefault(x => x.Id == request.CustomerId);
                var dataNew = new GoodsDeliveryNoteOfSim()
                {
                    Code = debtCode,
                    AgentId = request.AgentId,
                    approvedStatus = Commons.Enums.ApprovedStatus.Waiting,
                    CreateBy = new Guid(userId),
                    UpdateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    FormOfDeliveryId = request.FormOfDeliveryId,
                    FormOfDeliveryCode = request.FormOfDeliveryCode,
                    OrderIds = request.OrderIds,
                    ListSimNumberInOrder = request.ListSimNumberInOrder ?? "",
                    CustomerId = request.CustomerId,
                    CustomerName = customer?.FullName ?? "",
                    CustomerAddress = request.CustomerAddress,
                    CustomerPhone = request.CustomerPhone,
                    PayOrderType = request.PayOrderType,
                    Deposit = request.Deposit,
                    OrderPrice = request.OrderPrice,
                    TienDaThu = request.TienDaThu,
                    PhaiThuConLai = request.PhaiThuConLai,
                    OldDebt = request.OldDebt,
                    NewDebt = request.NewDebt,
                    PhoneCard = request.PhoneCard,
                    BankId = request.BankId,
                    FlagThuHo = request.FlagThuHo,
                    COD = request.COD,
                    FlagCOD = request.FlagCOD,
                    OtherFee = request.OtherFee,
                    ShippingCode = request.ShippingCode,
                    ShippingFee = request.ShippingFee,
                    ShippingUnitId = request.ShippingUnitId,
                    DeliveryAgent = request.DeliveryAgent,
                    Note = request.Note ?? "",
                    IsDelete = false,
                    InstallmentPeriod = request.InstallmentPeriod,
                    DateOfPayment = DateTime.Now.Day,
                    InstallmentEndDate = DateTime.Now.AddMonths(request.InstallmentPeriod),
                    DownPayment = request.DownPayment,
                    InstallmentPayment = request.InstallmentPayment,
                    MonthlyInstallmentPayment = request.MonthlyInstallmentPayment,
                    InterestRate = request.InterestRate,
                    DeliveryDate = request.DeliveryDate,
                };
                _context.GoodsDeliveryNoteOfSim.Add(dataNew);
                _context.SaveChanges();

                if (
                    dataNew.FormOfDeliveryId == 1
                    || dataNew.FormOfDeliveryId == 3
                    || dataNew.FormOfDeliveryId == 5
                    || dataNew.FormOfDeliveryId == 6
                    || dataNew.FormOfDeliveryId == 7
                    || dataNew.FormOfDeliveryId == 12
                )
                {
                    //Ghi công nợ vào tài khoản ngân hàng
                    if (request.PayOrderType == PaymentType.Online)
                    {
                        var dataBank = new DebtBank()
                        {
                            InvoiceId = dataNew.Id,
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataNew.approvedStatus,
                            BankId = request.BankId ?? 0,
                            DebtCode = debtCode,
                            Receivables = dataNew.TienDaThu,
                            Liabilities = 0,
                            FinalDebt = dataNew.TienDaThu,
                            Description = "Công nợ bank cho phiếu xuất sim " + debtCode,
                            Note = dataNew.Note,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtBanks.Add(dataBank);
                        var bank = _context.Banks.FirstOrDefault(x => x.Id == dataNew.BankId);
                        _ = TelegramHelper.SendMessage(
                            -4286160390,
                            "Phiếu Xuất Sim: "
                                + dataNew.Code
                                + " vừa thanh toán online số tiền "
                                + dataNew.TienDaThu
                                + " vào tài khoản "
                                + bank?.AccOwner
                                + " - "
                                + bank?.AccNumber
                        );
                    }
                    else
                    {
                        //Ghi công nợ cho nhân viên bán sim
                        var dataStaff = new DebtStaff()
                        {
                            InvoiceId = dataNew.Id,
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataNew.approvedStatus,
                            StaffId = new Guid(userId),
                            DebtCode = debtCode,
                            Receivables = dataNew.TienDaThu,
                            Liabilities = 0,
                            FinalDebt = dataNew.TienDaThu,
                            Description =
                                "Công nợ cho người tạo phiếu cho phiếu xuất sim " + debtCode,
                            Note = dataNew.Note,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtStaffs.Add(dataStaff);
                    }
                }
                //Ghi công nợ cho bên vận chuyển
                if (dataNew.FormOfDeliveryId == 4 || dataNew.FormOfDeliveryId == 8)
                {
                    var dataShipping = new DebtShipping()
                    {
                        CreateBy = new Guid(userId),
                        CreateTime = DateTime.Now,
                        approvedStatus = dataNew.approvedStatus,
                        ShippingId = dataNew.ShippingUnitId ?? 0,
                        DebtCode = debtCode,
                        InvoiceId = dataNew.Id,
                        Receivables = dataNew.COD,
                        Liabilities = dataNew.ShippingFee,
                        FinalDebt = dataNew.COD - dataNew.ShippingFee,
                        Description = "Công nợ shipping cho phiếu xuất sim " + debtCode,
                        Note = dataNew.Note,
                        UpdateBy = new Guid(userId),
                        UpdateTime = DateTime.Now,
                    };
                    _context.DebtShippings.Add(dataShipping);
                }
                //Phát sinh công nợ khách hàng nếu chưa thanh toán hết
                if (dataNew.PhaiThuConLai != 0)
                {
                    var dataCustomer = new DebtAgent()
                    {
                        InvoiceId = dataNew.Id,
                        CreateBy = new Guid(userId),
                        CreateTime = DateTime.Now,
                        approvedStatus = dataNew.approvedStatus,
                        AgentId = dataNew.CustomerId ?? new Guid(),
                        DebtCode = debtCode,
                        Receivables = dataNew.PhaiThuConLai > 0 ? dataNew.PhaiThuConLai : 0,
                        Liabilities = dataNew.PhaiThuConLai < 0 ? dataNew.PhaiThuConLai * -1 : 0,
                        FinalDebt = dataNew.PhaiThuConLai,
                        Description = "Công nợ của người mua hàng cho phiếu xuất sim " + debtCode,
                        UpdateBy = new Guid(userId),
                        UpdateTime = DateTime.Now,
                    };
                    _context.DebtAgents.Add(dataCustomer);
                }
                //
                foreach (var simInfo in request.SimInfosInOrders)
                {
                    //Ghi công nợ cho bên nhà cung cấp sim
                    var owner = _context.Users.FirstOrDefault(x =>
                        x.Id == simInfo.AgentId && x.IsAgent == true
                    );
                    if (owner != null)
                    {
                        var dataAgent = new DebtAgent()
                        {
                            InvoiceId = dataNew.Id,
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataNew.approvedStatus,
                            AgentId = simInfo.AgentId ?? new Guid(),
                            DebtCode = debtCode,
                            Receivables = 0,
                            Liabilities = simInfo.PriceAfterDiscountAgent,
                            FinalDebt = 0 - simInfo.PriceAfterDiscountAgent,
                            Description = "Công nợ của nhà bán hàng cho phiếu xuất sim " + debtCode,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtAgents.Add(dataAgent);
                    }
                    //Ghi data cho dữ liệu sim trong phiếu xuất sim
                    var simInDebt = new SimInfosInOrder()
                    {
                        GDNId = dataNew.Id,
                        OrderId = simInfo.OrderId,
                        SimId = simInfo.SimId,
                        SimNumber = simInfo.SimNumber,
                        SimSeria = simInfo.SimSeria ?? "",
                        SimEmbryoFee = simInfo.SimEmbryoFee,
                        SimServiceFee = simInfo.SimServiceFee,
                        PriceOfSim = simInfo.PriceOfSim,
                        DiscountOfSim = simInfo.DiscountOfSim,
                        PriceOfDiscount = simInfo.PriceOfDiscount,
                        PriceAfterDiscount = simInfo.PriceAfterDiscount,
                        AgentId = simInfo.AgentId,
                        AgentName = simInfo.AgentName ?? "",
                        PriceOfAgent = simInfo.PriceOfAgent,
                        DiscountOfAgent = simInfo.DiscountOfAgent,
                        PriceOfDiscountAgent = simInfo.PriceOfDiscountAgent,
                        PriceAfterDiscountAgent = simInfo.PriceAfterDiscountAgent,
                    };
                    _context.SimInfosInOrders.Add(simInDebt);
                }
                if (
                    dataNew.FormOfDeliveryId == 2
                    || dataNew.FormOfDeliveryId == 9
                    || dataNew.FormOfDeliveryId == 10
                    || dataNew.FormOfDeliveryId == 11
                )
                {
                    //Ghi công nợ vào tài khoản ngân hàng
                    if (request.PayOrderType == PaymentType.Online)
                    {
                        var dataBank = new DebtBank()
                        {
                            InvoiceId = dataNew.Id,
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataNew.approvedStatus,
                            BankId = request.BankId ?? 0,
                            DebtCode = debtCode,
                            Receivables = dataNew.TienDaThu,
                            Liabilities = 0,
                            FinalDebt = dataNew.TienDaThu,
                            Description = "Công nợ bank cho phiếu xuất sim " + debtCode,
                            Note = dataNew.Note,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtBanks.Add(dataBank);

                        var bank = _context.Banks.FirstOrDefault(x => x.Id == dataNew.BankId);
                        _ = TelegramHelper.SendMessage(
                            -4286160390,
                            "Phiếu Xuất Sim: "
                                + dataNew.Code
                                + " vừa thanh toán online số tiền "
                                + dataNew.TienDaThu
                                + " vào tài khoản "
                                + bank?.AccOwner
                                + " - "
                                + bank?.AccNumber
                        );
                    }
                    else
                    {
                        //Phát sinh đại lý thu hộ
                        var dataDeliveryAgent = new DebtAgent()
                        {
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataNew.approvedStatus,
                            AgentId = dataNew.DeliveryAgent ?? new Guid(),
                            DebtCode = debtCode,
                            InvoiceId = dataNew.Id,
                            Receivables = 0,
                            Liabilities = dataNew.TienDaThu,
                            FinalDebt = 0 - dataNew.TienDaThu,
                            Description =
                                "Công nợ của đại lí giao hộ hàng cho phiếu xuất sim " + debtCode,
                            Note = dataNew.Note,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtAgents.Add(dataDeliveryAgent);
                    }
                }

                var result = _context.SaveChanges();

                if (dataNew.OrderIds != null)
                {
                    var orderIds = dataNew.OrderIds.Split(',');
                    if (orderIds.Length > 0)
                    {
                        var orders = _context
                            .SIMOrders.Where(x => orderIds.Contains(x.Id.ToString()))
                            .ToList();
                        foreach (var order in orders)
                        {
                            var simPriceForUser = _context
                                .SimInfosInOrders.Where(x => x.OrderId.Equals(order.Id))
                                .ToList()
                                .Sum(x => x.PriceAfterDiscount);
                            order.PriceOrder = simPriceForUser;
                            order.debtId = dataNew.Id;
                            order.Status = StatusOrder.WaitingApproved;
                            if (order.PIC.ToString() == "00000000-0000-0000-0000-000000000000")
                            {
                                order.PIC = new Guid(userId);
                            }
                        }
                        _context.SIMOrders.UpdateRange(orders);
                        _context.SaveChanges();
                    }
                }

                LogAction logAction = new LogAction()
                {
                    ActionName = "Tạo PXSim",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(request),
                    OldData = "",
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
                    Message = "Có lỗi trong quá trình tạo công nợ.",
                };
            }
        }

        public ResponseDataModel<string> Delete(int Id, Guid userId)
        {
            try
            {
                var dataEntity = _context.GoodsDeliveryNoteOfSim.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                var oldData = JsonConvert.SerializeObject(dataEntity);
                var gdnsCode = dataEntity.Code;
                //Xóa công nợ bank
                var debtbank = _context.DebtBanks.Where(x => x.DebtCode == gdnsCode);
                if (debtbank != null)
                {
                    _context.DebtBanks.RemoveRange(debtbank);
                }
                //Xóa công nợ Agent
                var debtAgent = _context.DebtAgents.Where(x => x.DebtCode == gdnsCode);
                if (debtAgent != null)
                {
                    _context.DebtAgents.RemoveRange(debtAgent);
                }
                //Xóa công nợ Staff
                var debtStaff = _context.DebtStaffs.Where(x => x.DebtCode == gdnsCode);
                if (debtStaff != null)
                {
                    _context.DebtStaffs.RemoveRange(debtStaff);
                }
                //Xóa công nợ Shipping
                var debtShipping = _context.DebtShippings.Where(x => x.DebtCode == gdnsCode);
                if (debtShipping != null)
                {
                    _context.DebtShippings.RemoveRange(debtShipping);
                }
                //Xóa Order
                var order = _context.SIMOrders.Where(x => x.debtId == Id);
                if (order != null)
                {
                    _context.SIMOrders.RemoveRange(order);
                }
                //
                _context.GoodsDeliveryNoteOfSim.Remove(dataEntity);
                _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa PXSim",
                    ControllerName = "",
                    CreateBy = userId,
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = "",
                    OldData = oldData,
                };
                _logAction.InsertLogAction(logAction);
                return new ResponseDataModel<string>() { Code = "1", Message = "Xóa thành công." };
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

        public GoodsDeliveryNoteOfSimModel Detail(int Id)
        {
            GoodsDeliveryNoteOfSimModel result = new GoodsDeliveryNoteOfSimModel();
            var dataEntity = _context.GoodsDeliveryNoteOfSim.FirstOrDefault(x => x.Id == Id);
            var createByStr = "";
            var createBy = _context.Users.FirstOrDefault(x => x.Id == dataEntity.CreateBy);
            if (createBy != null)
                createByStr = createBy.FullName;
            var approvedByStr = "";
            var approvedBy = _context.Users.FirstOrDefault(x => x.Id == dataEntity.ApprovedBy);
            if (approvedBy != null)
                approvedByStr = approvedBy.FullName;
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Code = dataEntity.Code;
                result.OrderIds = dataEntity.OrderIds;
                result.CustomerId = dataEntity.CustomerId;
                result.CustomerName = dataEntity.CustomerName;
                result.CustomerAddress = dataEntity.CustomerAddress;
                result.CustomerPhone = dataEntity.CustomerPhone;
                result.AgentId = dataEntity.AgentId;
                result.Deposit = dataEntity.Deposit;
                result.OrderPrice = dataEntity.OrderPrice;
                result.TienDaThu = dataEntity.TienDaThu;
                result.PhaiThuConLai = dataEntity.PhaiThuConLai;
                result.OldDebt = dataEntity.OldDebt;
                result.NewDebt = dataEntity.NewDebt;
                result.PhoneCard = dataEntity.PhoneCard;
                result.PayOrderType = dataEntity.PayOrderType;
                result.BankId = dataEntity.BankId;
                result.FormOfDeliveryId = dataEntity.FormOfDeliveryId;
                result.FormOfDeliveryCode = dataEntity.FormOfDeliveryCode;
                result.FlagThuHo = dataEntity.FlagThuHo;
                result.COD = dataEntity.COD;
                result.FlagCOD = dataEntity.FlagCOD;
                result.OtherFee = dataEntity.OtherFee;
                result.ShippingCode = dataEntity.ShippingCode;
                result.ShippingFee = dataEntity.ShippingFee;
                result.ShippingUnitId = dataEntity.ShippingUnitId;
                result.DeliveryAgent = dataEntity.DeliveryAgent;
                result.Note = dataEntity.Note;
                result.CreateBy = dataEntity.CreateBy;
                result.CreateTime = dataEntity.CreateTime;
                result.AprovedTime = dataEntity.ApprovedTime;
                result.ApprovedBy = dataEntity.ApprovedBy;
                result.SimInfosInOrders = new();
                result.InstallmentPeriod = dataEntity.InstallmentPeriod;
                result.DateOfPayment = dataEntity.DateOfPayment;
                result.InstallmentEndDate = dataEntity.InstallmentEndDate;
                result.DownPayment = dataEntity.DownPayment;
                result.InstallmentPayment = dataEntity.InstallmentPayment;
                result.MonthlyInstallmentPayment = dataEntity.MonthlyInstallmentPayment;
                result.InterestRate = dataEntity.InterestRate;
                result.DeliveryDate = dataEntity.DeliveryDate;
                var simInOrders = _context.SimInfosInOrders.Where(x => x.GDNId == Id).ToList();
                foreach (var simInfo in simInOrders)
                {
                    SimInfosInOrderModel simInOrderModel = new()
                    {
                        Id = simInfo.Id,
                        GDNId = simInfo.GDNId,
                        OrderId = simInfo.OrderId,
                        SimId = simInfo.SimId,
                        SimNumber = simInfo.SimNumber,
                        SimSeria = simInfo.SimSeria ?? "",
                        SimEmbryoFee = simInfo.SimEmbryoFee,
                        SimServiceFee = simInfo.SimServiceFee,
                        PriceOfSim = simInfo.PriceOfSim,
                        DiscountOfSim = simInfo.DiscountOfSim,
                        PriceOfDiscount = simInfo.PriceOfDiscount,
                        PriceAfterDiscount = simInfo.PriceAfterDiscount,
                        AgentId = simInfo.AgentId,
                        AgentName = simInfo.AgentName ?? "",
                        PriceOfAgent = simInfo.PriceOfAgent,
                        DiscountOfAgent = simInfo.DiscountOfAgent,
                        PriceOfDiscountAgent = simInfo.PriceOfDiscountAgent,
                        PriceAfterDiscountAgent = simInfo.PriceAfterDiscountAgent,
                    };
                    result.SimInfosInOrders.Add(simInOrderModel);
                }
            }
            return result;
        }

        public ResponseDataViewModel<GoodsDeliveryNoteOfSimViewModel> GetGoodsDeliveryNoteOfSim(
            GoodsDeliveryNoteOfSimFilterRequest request
        )
        {
            var dataEntity = _context
                .GoodsDeliveryNoteOfSim.Where(x => !x.IsDelete)
                .OrderByDescending(x => x.UpdateTime)
                .ToList();
            if (request.agentIds.Count > 0)
            {
                dataEntity = dataEntity
                    .Where(x => request.agentIds.Contains(x.AgentId.ToString()))
                    .OrderByDescending(x => x.UpdateTime)
                    .ToList();
            }
            if (request.staffIds.Count > 0)
            {
                dataEntity = dataEntity
                    .Where(x => request.staffIds.Contains(x.CreateBy.ToString()))
                    .OrderByDescending(x => x.UpdateTime)
                    .ToList();
            }
            if (!string.IsNullOrEmpty(request.userId))
            {
                dataEntity = dataEntity
                    .Where(x => x.CreateBy.ToString() == request.userId)
                    .OrderByDescending(x => x.UpdateTime)
                    .ToList();
            }
            if (request.apprStatus != null)
            {
                dataEntity = dataEntity
                    .Where(x => x.approvedStatus == request.apprStatus)
                    .OrderByDescending(x => x.UpdateTime)
                    .ToList();
            }
            var data = new List<GoodsDeliveryNoteOfSimViewModel>();
            var idx = 0;
            foreach (var item in dataEntity)
            {
                var agent = _context.Users.FirstOrDefault(x => x.Id == item.AgentId)?.FullName;
                var createBy = _context.Users.FirstOrDefault(x => x.Id == item.CreateBy);
                var apprBy = _context.Users.FirstOrDefault(x => x.Id == item.ApprovedBy);
                idx++;
                data.Add(new GoodsDeliveryNoteOfSimViewModel() { });
            }
            //
            return new ResponseDataViewModel<GoodsDeliveryNoteOfSimViewModel>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
                    {
                        keyword = "",
                        pageIndex = 1,
                        pageSize = 100,
                    },
                    dataEntity.Count()
                ),
                Data = data,
            };
        }

        public ResponseDataModel<string> Update(GoodsDeliveryNoteOfSimModel request, string userId)
        {
            try
            {
                var dataEntity = _context.GoodsDeliveryNoteOfSim.FirstOrDefault(x =>
                    x.Id == request.Id && x.approvedStatus != ApprovedStatus.Approved
                );
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại hoặc đã được duyệt.",
                    };
                }
                var oldData = JsonConvert.SerializeObject(dataEntity);
                dataEntity.PayOrderType = request.PayOrderType;
                dataEntity.Deposit = request.Deposit;
                dataEntity.OrderPrice = request.OrderPrice;
                dataEntity.TienDaThu = request.TienDaThu;
                dataEntity.PhaiThuConLai = request.PhaiThuConLai;
                dataEntity.OldDebt = request.OldDebt;
                dataEntity.NewDebt = request.NewDebt;
                dataEntity.PhoneCard = request.PhoneCard;
                dataEntity.BankId = request.BankId;
                dataEntity.FormOfDeliveryId = request.FormOfDeliveryId;
                dataEntity.FormOfDeliveryCode = request.FormOfDeliveryCode;
                dataEntity.AgentId = request.AgentId;
                dataEntity.FlagThuHo = request.FlagThuHo;
                dataEntity.COD = request.COD;
                dataEntity.FlagCOD = request.FlagCOD;
                dataEntity.OtherFee = request.OtherFee;
                dataEntity.ShippingCode = request.ShippingCode;
                dataEntity.ShippingFee = request.ShippingFee;
                dataEntity.ShippingUnitId = request.ShippingUnitId;
                dataEntity.DeliveryAgent = request.DeliveryAgent;
                dataEntity.Note = request.Note ?? "";
                //
                dataEntity.InstallmentPeriod = request.InstallmentPeriod;
                dataEntity.DownPayment = request.DownPayment;
                dataEntity.InstallmentPayment = request.InstallmentPayment;
                dataEntity.MonthlyInstallmentPayment = request.MonthlyInstallmentPayment;
                dataEntity.InterestRate = request.InterestRate;
                dataEntity.DeliveryDate = request.DeliveryDate;
                dataEntity.UpdateBy = new Guid(userId);
                dataEntity.UpdateTime = DateTime.Now;
                dataEntity.approvedStatus = ApprovedStatus.Waiting;

                _context.GoodsDeliveryNoteOfSim.Update(dataEntity);

                if (
                    dataEntity.FormOfDeliveryId == 1
                    || dataEntity.FormOfDeliveryId == 3
                    || dataEntity.FormOfDeliveryId == 5
                    || dataEntity.FormOfDeliveryId == 6
                    || dataEntity.FormOfDeliveryId == 7
                    || dataEntity.FormOfDeliveryId == 12
                )
                {
                    //Cập nhật công nợ bank
                    if (request.PayOrderType == PaymentType.Online)
                    {
                        var dataBank = _context.DebtBanks.FirstOrDefault(x =>
                            x.DebtCode == dataEntity.Code
                        );
                        if (dataBank != null)
                        {
                            dataBank.InvoiceId = dataEntity.Id;
                            dataBank.BankId = request.BankId ?? 0;
                            dataBank.Receivables = dataEntity.TienDaThu;
                            dataBank.Liabilities = 0;
                            dataBank.FinalDebt = dataEntity.TienDaThu;
                            dataBank.UpdateBy = new Guid(userId);
                            dataBank.UpdateTime = DateTime.Now;
                            _context.DebtBanks.Update(dataBank);
                        }
                        else
                        {
                            var dataBankNew = new DebtBank()
                            {
                                InvoiceId = dataEntity.Id,
                                CreateBy = new Guid(userId),
                                CreateTime = DateTime.Now,
                                approvedStatus = dataEntity.approvedStatus,
                                BankId = request.BankId ?? 0,
                                DebtCode = dataEntity.Code,
                                Receivables = dataEntity.TienDaThu,
                                Liabilities = 0,
                                FinalDebt = dataEntity.TienDaThu,
                                Description = "Công nợ bank cho phiếu xuất kho " + dataEntity.Code,
                                Note = dataEntity.Note,
                                UpdateBy = new Guid(userId),
                                UpdateTime = DateTime.Now,
                            };
                            _context.DebtBanks.Add(dataBankNew);
                        }
                    }
                    else
                    {
                        var dataBank = _context.DebtBanks.FirstOrDefault(x =>
                            x.DebtCode == dataEntity.Code
                        );
                        if (dataBank != null)
                        {
                            _context.DebtBanks.Remove(dataBank);
                        }

                        //Cập nhật công nợ cho nhân viên
                        var dataStaff = _context.DebtStaffs.FirstOrDefault(x =>
                            x.DebtCode == dataEntity.Code
                        );
                        if (dataStaff != null)
                        {
                            dataStaff.Receivables = dataEntity.TienDaThu;
                            dataStaff.Liabilities = dataEntity.ShippingFee;
                            dataStaff.FinalDebt = dataEntity.TienDaThu - dataEntity.ShippingFee;
                            dataStaff.UpdateBy = new Guid(userId);
                            dataStaff.UpdateTime = DateTime.Now;
                            _context.DebtStaffs.Update(dataStaff);
                        }
                        else
                        {
                            //Ghi công nợ cho nhân viên bán sim
                            var dataStaffNew = new DebtStaff()
                            {
                                InvoiceId = dataEntity.Id,
                                CreateBy = new Guid(userId),
                                CreateTime = DateTime.Now,
                                approvedStatus = dataEntity.approvedStatus,
                                StaffId = new Guid(userId),
                                DebtCode = dataEntity.Code,
                                Receivables = dataEntity.TienDaThu,
                                Liabilities = dataEntity.ShippingFee,
                                FinalDebt = dataEntity.TienDaThu - dataEntity.ShippingFee,
                                Description =
                                    "Công nợ cho người tạo phiếu cho phiếu xuất kho "
                                    + dataEntity.Code,
                                Note = dataEntity.Note,
                                UpdateBy = new Guid(userId),
                                UpdateTime = DateTime.Now,
                            };
                            _context.DebtStaffs.Add(dataStaffNew);
                        }
                    }
                }
                //
                //Cập nhật công nợ nhà vận chuyển
                if (dataEntity.FormOfDeliveryId == 4 || dataEntity.FormOfDeliveryId == 8)
                {
                    var dataShipping = _context.DebtShippings.FirstOrDefault(x =>
                        x.DebtCode == dataEntity.Code
                    );
                    if (dataShipping != null)
                    {
                        dataShipping.ShippingId = dataEntity.ShippingUnitId ?? 0;
                        dataShipping.Receivables = dataEntity.COD;
                        dataShipping.Liabilities = dataEntity.ShippingFee;
                        dataShipping.FinalDebt = dataEntity.COD - dataEntity.ShippingFee;
                        dataShipping.UpdateBy = new Guid(userId);
                        dataShipping.UpdateTime = DateTime.Now;

                        _context.DebtShippings.Update(dataShipping);
                    }
                    else
                    {
                        var dataShippingNew = new DebtShipping()
                        {
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataEntity.approvedStatus,
                            ShippingId = dataEntity.ShippingUnitId ?? 0,
                            DebtCode = dataEntity.Code,
                            InvoiceId = dataEntity.Id,
                            Receivables = dataEntity.COD,
                            Liabilities = dataEntity.ShippingFee,
                            FinalDebt = dataEntity.COD - dataEntity.ShippingFee,
                            Description = "Công nợ shipping cho phiếu xuất kho " + dataEntity.Code,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtShippings.Add(dataShippingNew);
                    }
                }
                else
                {
                    var dataShipping = _context.DebtShippings.FirstOrDefault(x =>
                        x.DebtCode == dataEntity.Code
                    );
                    if (dataShipping != null)
                    {
                        _context.DebtShippings.Remove(dataShipping);
                    }
                }

                //remove data old agent
                var dataAgents = _context.DebtAgents.Where(x => x.DebtCode == dataEntity.Code);
                _context.DebtAgents.RemoveRange(dataAgents);

                //Phát sinh công nợ khách hàng nếu chưa thanh toán hết
                if (dataEntity.PhaiThuConLai != 0)
                {
                    var dataCustomer = new DebtAgent()
                    {
                        InvoiceId = dataEntity.Id,
                        CreateBy = new Guid(userId),
                        CreateTime = DateTime.Now,
                        approvedStatus = dataEntity.approvedStatus,
                        AgentId = dataEntity.CustomerId ?? new Guid(),
                        DebtCode = dataEntity.Code,
                        Receivables = dataEntity.PhaiThuConLai > 0 ? dataEntity.PhaiThuConLai : 0,
                        Liabilities =
                            dataEntity.PhaiThuConLai < 0 ? dataEntity.PhaiThuConLai * -1 : 0,
                        FinalDebt = dataEntity.PhaiThuConLai,
                        Description =
                            "Công nợ của người mua hàng cho phiếu xuất sim " + dataEntity.Code,
                        UpdateBy = new Guid(userId),
                        UpdateTime = DateTime.Now,
                    };
                    _context.DebtAgents.Add(dataCustomer);
                }
                //
                foreach (var simInfo in request.SimInfosInOrders)
                {
                    //Ghi công nợ cho bên nhà cung cấp sim
                    var owner = _context.Users.FirstOrDefault(x =>
                        x.Id == simInfo.AgentId && x.IsAgent == true
                    );
                    if (owner != null)
                    {
                        var dataAgent = new DebtAgent()
                        {
                            InvoiceId = dataEntity.Id,
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataEntity.approvedStatus,
                            AgentId = simInfo.AgentId ?? new Guid(),
                            DebtCode = dataEntity.Code,
                            Receivables = 0,
                            Liabilities = simInfo.PriceAfterDiscountAgent,
                            FinalDebt = 0 - simInfo.PriceAfterDiscountAgent,
                            Description =
                                "Công nợ của nhà bán hàng cho phiếu xuất sim " + dataEntity.Code,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtAgents.Add(dataAgent);
                    }
                    //Cập nhật dữ liệu sim trong phiếu xuất sim
                    var simInDebt = _context
                        .SimInfosInOrders.Where(x => x.Id == simInfo.Id)
                        .FirstOrDefault();
                    simInDebt.GDNId = dataEntity.Id;
                    simInDebt.OrderId = simInfo.OrderId;
                    simInDebt.SimId = simInfo.SimId;
                    simInDebt.SimSeria = simInfo?.SimSeria ?? "";
                    simInDebt.SimEmbryoFee = simInfo?.SimEmbryoFee ?? 0;
                    simInDebt.SimServiceFee = simInfo?.SimServiceFee ?? 0;
                    simInDebt.PriceOfSim = simInfo?.PriceOfSim ?? 0;
                    simInDebt.DiscountOfSim = simInfo.DiscountOfSim;
                    simInDebt.PriceOfDiscount = simInfo.PriceOfDiscount;
                    simInDebt.PriceAfterDiscount = simInfo.PriceAfterDiscount;
                    simInDebt.AgentId = simInfo.AgentId;
                    simInDebt.AgentName = simInfo?.AgentName ?? "";
                    simInDebt.PriceOfAgent = simInfo.PriceOfAgent;
                    simInDebt.DiscountOfAgent = simInfo.DiscountOfAgent;
                    simInDebt.PriceOfDiscountAgent = simInfo.PriceOfDiscountAgent;
                    simInDebt.PriceAfterDiscountAgent = simInfo.PriceAfterDiscountAgent;
                    _context.SimInfosInOrders.Update(simInDebt);
                }
                //Phát sinh đại lý thu hộ
                if (
                    dataEntity.FormOfDeliveryId == 2
                    || dataEntity.FormOfDeliveryId == 9
                    || dataEntity.FormOfDeliveryId == 10
                    || dataEntity.FormOfDeliveryId == 11
                )
                {
                    //Ghi công nợ vào tài khoản ngân hàng
                    if (request.PayOrderType == PaymentType.Online)
                    {
                        var dataBank = new DebtBank()
                        {
                            InvoiceId = dataEntity.Id,
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataEntity.approvedStatus,
                            BankId = request.BankId ?? 0,
                            DebtCode = dataEntity.Code,
                            Receivables = dataEntity.TienDaThu,
                            Liabilities = 0,
                            FinalDebt = dataEntity.TienDaThu,
                            Description = "Công nợ bank cho phiếu xuất sim " + dataEntity.Code,
                            Note = dataEntity.Note,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtBanks.Add(dataBank);
                    }
                    else
                    {
                        //Phát sinh đại lý thu hộ
                        var dataDeliveryAgent = new DebtAgent()
                        {
                            InvoiceId = dataEntity.Id,
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataEntity.approvedStatus,
                            AgentId = dataEntity.DeliveryAgent ?? new Guid(),
                            DebtCode = dataEntity.Code,
                            Receivables = 0,
                            Liabilities = dataEntity.TienDaThu,
                            FinalDebt = 0 - dataEntity.TienDaThu,
                            Description =
                                "Công nợ của đại lí giao hộ hàng cho phiếu xuất sim "
                                + dataEntity.Code,
                            Note = dataEntity.Note,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtAgents.Add(dataDeliveryAgent);
                    }
                }
                var result = _context.SaveChanges();
                if (request.OrderIds != null)
                {
                    var orderIds = request.OrderIds.Split(',');
                    if (orderIds.Length > 0)
                    {
                        var orders = _context
                            .SIMOrders.Where(x => orderIds.Contains(x.Id.ToString()))
                            .ToList();
                        foreach (var order in orders)
                        {
                            var simPriceForUser = _context
                                .SimInfosInOrders.Where(x => x.OrderId.Equals(order.Id))
                                .ToList()
                                .Sum(x => x.PriceAfterDiscount);
                            order.PriceOrder = simPriceForUser;
                            order.Status = StatusOrder.WaitingApproved;
                            if (order.PIC.ToString() == "00000000-0000-0000-0000-000000000000")
                            {
                                order.PIC = new Guid(userId);
                            }
                        }
                        _context.SIMOrders.UpdateRange(orders);
                        _context.SaveChanges();
                    }
                }
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Cập nhật PXSim",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
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
                    Message = "Có lỗi trong quá trình cập nhật.",
                };
            }
        }

        public ResponseDataViewModel<GoodsDeliveryNoteOfSimViewModel> GetGoodsDeliveryNoteOfSimForFilter(
            GoodsDeliveryNoteOfSimFilterRequest request
        )
        {
            var dataEntity = _context
                .GoodsDeliveryNoteOfSim.OrderBy(x => x.approvedStatus)
                .ThenByDescending(x => x.UpdateTime)
                .ToList();
            if (request.agentIds.Count > 0)
            {
                dataEntity = dataEntity
                    .Where(x => request.agentIds.Contains(x.CustomerId.ToString()))
                    .OrderBy(x => x.approvedStatus)
                    .ToList();
            }
            if (!string.IsNullOrEmpty(request.userId))
            {
                dataEntity = dataEntity
                    .Where(x => x.CreateBy.ToString() == request.userId)
                    .OrderBy(x => x.approvedStatus)
                    .ToList();
            }
            else if (request.staffIds.Count > 0)
            {
                dataEntity = dataEntity
                    .Where(x => request.staffIds.Contains(x.CreateBy.ToString()))
                    .OrderBy(x => x.approvedStatus)
                    .ToList();
            }
            if (request.apprStatus != null && ((int)request.apprStatus).ToString() != "0")
            {
                dataEntity = dataEntity
                    .Where(x => x.approvedStatus == request.apprStatus)
                    .OrderBy(x => x.approvedStatus)
                    .ToList();
            }
            if (!string.IsNullOrEmpty(request.simNumber))
            {
                dataEntity = dataEntity
                    .Where(x =>
                        x.ListSimNumberInOrder.Replace(".", "")
                            .Contains(request.simNumber.Replace(".", ""))
                    )
                    .OrderBy(x => x.approvedStatus)
                    .ToList();
            }
            if (!string.IsNullOrEmpty(request.code))
            {
                dataEntity = dataEntity
                    .Where(x => x.Code.Contains(request.code))
                    .OrderBy(x => x.approvedStatus)
                    .ToList();
            }

            var dataPaging = dataEntity
                .Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .ToList();
            var data = new List<GoodsDeliveryNoteOfSimViewModel>();
            var idx = 0;
            foreach (var item in dataPaging)
            {
                var agent = _context.Users.FirstOrDefault(x => x.Id == item.AgentId)?.FullName;
                var createBy = _context.Users.FirstOrDefault(x => x.Id == item.CreateBy);
                var apprBy = _context.Users.FirstOrDefault(x => x.Id == item.ApprovedBy);
                var shippingName = _context
                    .ShippingUnits.FirstOrDefault(x => x.Id == item.ShippingUnitId)
                    ?.Name;
                var formOfDelivery = _context
                    .FormOfDeliveries.FirstOrDefault(x => x.Id == item.FormOfDeliveryId)
                    ?.Name;
                var deliveryName = "";
                if (
                    item.FormOfDeliveryId == 2
                    || item.FormOfDeliveryId == 9
                    || item.FormOfDeliveryId == 10
                    || item.FormOfDeliveryId == 11
                )
                {
                    deliveryName = agent;
                }
                else if (item.FormOfDeliveryId == 4)
                {
                    deliveryName = shippingName;
                }

                var orderIdsArr = item.OrderIds?.Split(',');
                List<string> sims = new();
                if (orderIdsArr?.Length > 0)
                {
                    //var agentId = _context.SIMOrders.FirstOrDefault(x => orderIdsArr.Contains(x.Id.ToString())).UserBuyId;
                    var orders = _context.SIMOrders.Where(x =>
                        orderIdsArr.Contains(x.Id.ToString())
                    );
                    var simIds = _context
                        .SIMWithOrders.Where(x => orderIdsArr.Contains(x.OrderId.ToString()))
                        .Select(x => x.SimId)
                        .ToList();
                    sims = _context
                        .SIMDetails.Where(x => simIds.Contains(x.Id))
                        .Select(x => x.SIMNumber)
                        .ToList();
                }
                idx++;
                data.Add(
                    new GoodsDeliveryNoteOfSimViewModel()
                    {
                        Id = item.Id,
                        Code = item.Code,
                        OrderIds = item.OrderIds,
                        CustomerId = item.CustomerId,
                        CustomerName = item.CustomerName,
                        CustomerAddress = item.CustomerAddress,
                        CustomerPhone = item.CustomerPhone,
                        AgentId = item.AgentId,
                        PayOrderType = item.PayOrderType,
                        OrderPrice = item.OrderPrice,
                        TienDaThu = item.TienDaThu,
                        PhaiThuConLai = item.PhaiThuConLai,
                        ListSimNumberInOrder = item.ListSimNumberInOrder,
                        Deposit = item.Deposit,
                        OldDebt = item.OldDebt,
                        NewDebt = item.NewDebt,
                        PhoneCard = item.PhoneCard,
                        BankId = item.BankId,
                        FormOfDeliveryId = formOfDelivery ?? "",
                        FormOfDeliveryCode = item.FormOfDeliveryCode,
                        FlagThuHo = item.FlagThuHo,
                        COD = item.COD,
                        FlagCOD = item.FlagCOD,
                        OtherFee = item.OtherFee,
                        ShippingCode = item.ShippingCode,
                        ShippingFee = item.ShippingFee,
                        ShippingUnitId = item.ShippingUnitId,
                        ShippingName = deliveryName,
                        DeliveryAgent = item.DeliveryAgent,
                        CreateBy = createBy?.FullName ?? "",
                        CreateTime = item.CreateTime.ToString("HH:mm dd.MM.yyyy"),
                        ApprovedTime = item.ApprovedTime.ToString("HH:mm dd.MM.yyyy"),
                        ApprovedBy = apprBy?.FullName ?? "",
                        approvedStatusStr = Enum.GetName(
                            typeof(ApprovedStatus),
                            item.approvedStatus
                        ),
                        Note = item.Note,
                        DeliveryDate = item.DeliveryDate?.ToString("HH:mm dd.MM.yyyy") ?? "",
                    }
                );
            }
            //
            return new ResponseDataViewModel<GoodsDeliveryNoteOfSimViewModel>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
                    {
                        keyword = "",
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    dataEntity.Count()
                ),
                Data = data,
            };
        }
    }
}
