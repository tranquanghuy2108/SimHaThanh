using System.Reflection;
using System.Runtime;
using System.Security.AccessControl;
using System.Security.Claims;
using ClosedXML.Excel;
using Commons.Enums;
using Commons.Models;
using ExcelDataReader;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.ViewModels;
using Repositories.Interface;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebSIMManager.Controllers
{
    [Authorize]
    public class SIMOrderController : BaseController
    {
        private readonly ISIMRepository _SIMRepository;
        private readonly ISIMOrderRepository _SIMOrderRepository;
        private readonly IAccountRepository _AccountRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IDebtRepository _debtRepository;
        private readonly IBankRepository _bankRepository;
        private readonly IShippingUnitRepository _shippingUnitRepository;
        private readonly IGoodsDeliveryNoteOfSimRepository _goodsDeliveryNoteOfSimRepository;
        private readonly ISystemConfigRepository _systemConfigRepository;
        private readonly IContactRepository _contactConfigRepository;
        private readonly IWebHostEnvironment _environment;

        public SIMOrderController(
            ISIMRepository SIMRepository,
            IAccountRepository accountRepository,
            ISIMOrderRepository sIMOrderRepository,
            IHttpContextAccessor httpContextAccessor,
            IDebtRepository debtRepository,
            IBankRepository bankRepository,
            IShippingUnitRepository shippingUnitRepository,
            IGoodsDeliveryNoteOfSimRepository goodsDeliveryNoteOfSimRepository,
            ISystemConfigRepository systemConfigRepository,
            IContactRepository contactConfigRepository,
            IWebHostEnvironment environment
        )
        {
            _SIMRepository = SIMRepository;
            _AccountRepository = accountRepository;
            _SIMOrderRepository = sIMOrderRepository;
            _httpContextAccessor = httpContextAccessor;
            _debtRepository = debtRepository;
            _bankRepository = bankRepository;
            _shippingUnitRepository = shippingUnitRepository;
            _goodsDeliveryNoteOfSimRepository = goodsDeliveryNoteOfSimRepository;
            _systemConfigRepository = systemConfigRepository;
            _contactConfigRepository = contactConfigRepository;
            _environment = environment;
        }

        // GET: SIMOrderController
        [Authorize(Roles = "Xem đơn hỏi mua")]
        public ActionResult Index(GetPagingRequest request)
        {
            ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
            return View();
        }

        public ActionResult SearchOrderNew([FromBody] OrderFilterRequest request)
        {
            request.userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                ClaimTypes.NameIdentifier
            );
            var data = _SIMOrderRepository.SearcSIMOrderPaging(request);
            return Json(data);
        }

        // GET: SIMOrderController/Details/5
        [Route("my-order")]
        [Authorize(Roles = "Xem đơn hỏi mua")]
        public ActionResult MyOrder()
        {
            ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
            return View();
        }

        public ActionResult SearchMyOrder([FromBody] OrderFilterRequest request)
        {
            request.userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                ClaimTypes.NameIdentifier
            );
            request.statusOrder = StatusOrder.Order;
            var data = _SIMOrderRepository.SearcSIMOrderPaging(request);
            return Json(data);
        }

        // GET: SIMOrderController/Details/5
        [Route("phieu-xuat-sim")]
        [Authorize(Roles = "Xuất sim")]
        public ActionResult PhieuXuatSim()
        {
            ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
            ViewBag.Staff = _AccountRepository.GetStaffForCombo();
            List<SelectListItem> selectListItems = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = ((int)ApprovedStatus.Waiting).ToString(),
                    Text = Enum.GetName(typeof(ApprovedStatus), ApprovedStatus.Waiting),
                },
                new SelectListItem()
                {
                    Value = ((int)ApprovedStatus.Approved).ToString(),
                    Text = Enum.GetName(typeof(ApprovedStatus), ApprovedStatus.Approved),
                },
                new SelectListItem()
                {
                    Value = ((int)ApprovedStatus.Reject).ToString(),
                    Text = Enum.GetName(typeof(ApprovedStatus), ApprovedStatus.Reject),
                },
            };
            @ViewBag.Status = selectListItems;
            return View();
        }

        public ActionResult SearchPhieuXuatSim(
            [FromBody] GoodsDeliveryNoteOfSimFilterRequest request
        )
        {
            //request.userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = _goodsDeliveryNoteOfSimRepository.GetGoodsDeliveryNoteOfSimForFilter(
                request
            );
            return Json(data);
        }

        public ActionResult OnAgentChange([FromBody] AgentChangeReqModel request)
        {
            //var data = _SIMOrderRepository.GetDiscountOfUser(request.agentId, request.price);
            var data = _AccountRepository.GetUserForEdit(new Guid(request.agentId));
            return Json(data);
        }

        public ActionResult GetDiscountOfUser([FromBody] AgentChangeReqModel request)
        {
            var data = _SIMOrderRepository.GetDiscountOfUser(request.agentId, request.price);
            return Json(data);
        }

        [Authorize(Roles = "Duyệt công nợ")]
        public ActionResult OnApprovedPXS([FromBody] ApprovedDebtRequest request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                ClaimTypes.NameIdentifier
            );
            var data = _goodsDeliveryNoteOfSimRepository.Approved(
                request.debtIds,
                request.status,
                userId
            );
            return Json(data);
        }

        [Authorize(Roles = "Duyệt đơn hỏi mua")]
        public ActionResult OnApprovedOrder([FromBody] UpdateStatusOrderRequest request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                ClaimTypes.NameIdentifier
            );
            var data = _SIMOrderRepository.UpdateStatusOrder(
                request.status,
                request.orderIds,
                userId
            );
            return Json(data);
        }

        public ActionResult CheckListOrderIsOneAgent([FromBody] RequestIdsModel request)
        {
            var data = _SIMOrderRepository.CheckListOrderIsOneAgent(request.ids);
            return Json(data);
        }

        public ActionResult CheckListOrderIsAvalible([FromBody] RequestIdsModel request)
        {
            var data = _SIMOrderRepository.CheckListOrderIsAvalible(request.ids);
            return Json(data);
        }

        public ActionResult CheckSimIdIsAvaliable([FromBody] RequestIdsModel request)
        {
            var data = _SIMRepository.CheckSimIdIsAvaliable(request.ids);
            return Json(data);
        }

        public ActionResult GetSimInfoForAskSim([FromBody] RequestSimNumberModel request)
        {
            var data = _SIMRepository.GetSimInfoForAskSim(request.simNumber);
            return Json(data);
        }

        public ActionResult GetOrderForAskSim([FromBody] GetPagingRequest request)
        {
            var data = _SIMOrderRepository.GetOrderForAskSim(request);
            return Json(data);
        }

        public ActionResult GetUserInfo(string userId)
        {
            var data = _AccountRepository.GetUserForEdit(new Guid(userId));
            return Json(data);
        }

        public ActionResult GetSimInfoInOrder([FromBody] RequestGetSimInfoInOrderModel request)
        {
            if (request != null)
            {
                var data = _SIMRepository.GetSIMInOrder(request);
                return Json(data);
            }
            else
                return Json(null);
        }

        public ActionResult GetSimInfoByIds([FromBody] RequestGetSimInfoInOrderModel request)
        {
            var simIdsList = request.simIds.Split(',').Select(s => int.Parse(s)).ToList();
            var data = _SIMRepository.GetSimInfoByIds(
                simIdsList,
                int.Parse(request.orderIds ?? "0")
            );
            return Json(data);
        }

        // GET: SIMOrderController/Edit/5
        [Route("create-sim-order")]
        [Authorize(Roles = "Tạo mới đơn hỏi mua")]
        public ActionResult Create(string simIds)
        {
            var ids = simIds.Split(',').Select(id => int.Parse(id)).ToList();
            List<SimInOrder> simInOrders = new();
            var simDataIds = _SIMRepository.GetSimInfoByIds(ids);
            foreach (var simInfo in simDataIds.simInfos)
            {
                simInOrders.Add(
                    new SimInOrder()
                    {
                        simId = simInfo.Id,
                        simPrice = simInfo.Price,
                        usingEsim = false,
                    }
                );
            }
            @ViewBag.SimInOrders = simInOrders;
            @ViewBag.SimIDs = simIds;
            @ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
            List<SelectListItem> payOrderSelectedItems = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = PaymentType.COD.ToString(),
                    Text = "Thanh toán tiền mặt",
                    Selected = true,
                },
                new SelectListItem()
                {
                    Value = PaymentType.Online.ToString(),
                    Text = "Thanh toán online",
                },
                new SelectListItem()
                {
                    Value = PaymentType.Company.ToString(),
                    Text = "Xuất hóa đơn công ty",
                },
                new SelectListItem()
                {
                    Value = PaymentType.Installment.ToString(),
                    Text = "Thanh toán trả góp",
                },
            };
            @ViewBag.PayOrderType = payOrderSelectedItems;
            List<SelectListItem> typePriceSimOrder = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.Defaul.ToString(),
                    Text = "Giá bán lẻ",
                    Selected = true,
                },
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.ForAgent.ToString(),
                    Text = "Giá cho đại lý",
                },
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.ForCollaborators.ToString(),
                    Text = "Giá cho cộng tác viên",
                },
            };
            @ViewBag.TypePriceSimOrder = typePriceSimOrder;
            var sysConfig = _systemConfigRepository.GetInstallmentSimConfig();
            @ViewBag.DailyInterestRate = sysConfig.Installment_DailyInterestRate;
            @ViewBag.MinimumPaymentRate = sysConfig.Installment_MinimumPaymentRate;
            @ViewBag.Staffs = _AccountRepository.GetStaffForCombo();
            ViewBag.SPContacts = _contactConfigRepository.GetSPContactForCombo();
            @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
            return View();
        }

        // POST: SIMOrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create-sim-order")]
        [Authorize(Roles = "Tạo mới đơn hỏi mua")]
        public ActionResult Create(SIMOrderModel request)
        {
            try
            {
                @ViewBag.SimInOrders = request.simInOrders;
                @ViewBag.SimIDs = string.Join(
                    ',',
                    request.simInOrders.Select(x => x.simId).ToList()
                );
                @ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
                @ViewBag.AgentInfo = _AccountRepository.GetUserForEdit(request.UserBuyId);
                request.UserId = new Guid(
                    _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier)
                );
                List<SelectListItem> payOrderSelectedItems = new List<SelectListItem>()
                {
                    new SelectListItem()
                    {
                        Value = PaymentType.COD.ToString(),
                        Text = "Thanh toán tiền mặt",
                        Selected = true,
                    },
                    new SelectListItem()
                    {
                        Value = PaymentType.Online.ToString(),
                        Text = "Thanh toán online",
                    },
                    new SelectListItem()
                    {
                        Value = PaymentType.Company.ToString(),
                        Text = "Xuất hóa đơn công ty",
                    },
                    new SelectListItem()
                    {
                        Value = PaymentType.Installment.ToString(),
                        Text = "Thanh toán trả góp",
                    },
                };
                @ViewBag.PayOrderType = payOrderSelectedItems;
                List<SelectListItem> typePriceSimOrder = new List<SelectListItem>()
                {
                    new SelectListItem()
                    {
                        Value = TypePriceSimOrder.Defaul.ToString(),
                        Text = "Giá bán lẻ",
                        Selected = true,
                    },
                    new SelectListItem()
                    {
                        Value = TypePriceSimOrder.ForAgent.ToString(),
                        Text = "Giá cho đại lý",
                    },
                    new SelectListItem()
                    {
                        Value = TypePriceSimOrder.ForCollaborators.ToString(),
                        Text = "Giá cho cộng tác viên",
                    },
                };
                @ViewBag.TypePriceSimOrder = typePriceSimOrder;
                var sysConfig = _systemConfigRepository.GetInstallmentSimConfig();
                @ViewBag.DailyInterestRate = sysConfig.Installment_DailyInterestRate;
                @ViewBag.MinimumPaymentRate = sysConfig.Installment_MinimumPaymentRate;
                @ViewBag.Staffs = _AccountRepository.GetStaffForCombo();
                ViewBag.SPContacts = _contactConfigRepository.GetSPContactForCombo();
                @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _SIMOrderRepository.CreateSIMOrder(request);
                if (result.Code == "1")
                {
                    //return RedirectToAction("Index", "SIM");
                    return RedirectToAction("Edit", new { id = result.Data });
                }
                else
                {
                    ModelState.AddModelError(string.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: SIMOrderController/Edit/5
        [Route("edit-sim-order")]
        [Authorize(Roles = "Sửa đơn hỏi mua")]
        public ActionResult Edit(int id)
        {
            @ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();

            List<SelectListItem> payOrderSelectedItems = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = PaymentType.COD.ToString(),
                    Text = "Thanh toán tiền mặt",
                    Selected = true,
                },
                new SelectListItem()
                {
                    Value = PaymentType.Online.ToString(),
                    Text = "Thanh toán online",
                },
                new SelectListItem()
                {
                    Value = PaymentType.Company.ToString(),
                    Text = "Xuất hóa đơn công ty",
                },
                new SelectListItem()
                {
                    Value = PaymentType.Installment.ToString(),
                    Text = "Thanh toán trả góp",
                },
            };
            @ViewBag.PayOrderType = payOrderSelectedItems;
            List<SelectListItem> typePriceSimOrder = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.Defaul.ToString(),
                    Text = "Giá bán lẻ",
                    Selected = true,
                },
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.ForAgent.ToString(),
                    Text = "Giá cho đại lý",
                },
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.ForCollaborators.ToString(),
                    Text = "Giá cho cộng tác viên",
                },
            };
            @ViewBag.TypePriceSimOrder = typePriceSimOrder;
            var sysConfig = _systemConfigRepository.GetInstallmentSimConfig();
            @ViewBag.DailyInterestRate = sysConfig.Installment_DailyInterestRate;
            @ViewBag.MinimumPaymentRate = sysConfig.Installment_MinimumPaymentRate;
            var data = _SIMOrderRepository.GetSIMOrder(id);

            @ViewBag.SimIDs = string.Join(',', data.simInOrders.Select(x => x.simId).ToList());
            @ViewBag.AgentInfo = _AccountRepository.GetUserForEdit(data.UserBuyId);
            @ViewBag.AllowEdit = data.Status <= StatusOrder.WaitingApproved;
            @ViewBag.AllowXuatSim = data.Status < StatusOrder.WaitingApproved;
            ViewBag.Staffs = _AccountRepository.GetStaffForCombo();
            ViewBag.SPContacts = _contactConfigRepository.GetSPContactForCombo();
            return View(data);
        }

        // POST: SIMOrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-sim-order")]
        [Authorize(Roles = "Sửa đơn hỏi mua")]
        public ActionResult Edit(SIMOrderModel request)
        {
            try
            {
                @ViewBag.SimIDs = string.Join(
                    ',',
                    request.simInOrders.Select(x => x.simId).ToList()
                );
                @ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
                @ViewBag.AgentInfo = _AccountRepository.GetUserForEdit(request.UserBuyId);

                List<SelectListItem> payOrderSelectedItems = new List<SelectListItem>()
                {
                    new SelectListItem()
                    {
                        Value = PaymentType.COD.ToString(),
                        Text = "Thanh toán tiền mặt",
                        Selected = true,
                    },
                    new SelectListItem()
                    {
                        Value = PaymentType.Online.ToString(),
                        Text = "Thanh toán online",
                    },
                    new SelectListItem()
                    {
                        Value = PaymentType.Company.ToString(),
                        Text = "Xuất hóa đơn công ty",
                    },
                    new SelectListItem()
                    {
                        Value = PaymentType.Installment.ToString(),
                        Text = "Thanh toán trả góp",
                    },
                };
                @ViewBag.PayOrderType = payOrderSelectedItems;
                List<SelectListItem> typePriceSimOrder = new List<SelectListItem>()
                {
                    new SelectListItem()
                    {
                        Value = TypePriceSimOrder.Defaul.ToString(),
                        Text = "Giá bán lẻ",
                        Selected = true,
                    },
                    new SelectListItem()
                    {
                        Value = TypePriceSimOrder.ForAgent.ToString(),
                        Text = "Giá cho đại lý",
                    },
                    new SelectListItem()
                    {
                        Value = TypePriceSimOrder.ForCollaborators.ToString(),
                        Text = "Giá cho cộng tác viên",
                    },
                };
                @ViewBag.TypePriceSimOrder = typePriceSimOrder;
                var sysConfig = _systemConfigRepository.GetInstallmentSimConfig();
                @ViewBag.DailyInterestRate = sysConfig.Installment_DailyInterestRate;
                @ViewBag.MinimumPaymentRate = sysConfig.Installment_MinimumPaymentRate;
                @ViewBag.Staffs = _AccountRepository.GetStaffForCombo();
                @ViewBag.AllowEdit = request.Status == StatusOrder.Order;
                @ViewBag.AllowXuatSim = request.Status < StatusOrder.WaitingApproved;
                ViewBag.SPContacts = _contactConfigRepository.GetSPContactForCombo();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _SIMOrderRepository.UpdateSIMOrder(request);
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult UpdateStatus([FromBody] UpdateOrderStatusModel model)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                ClaimTypes.NameIdentifier
            );
            var result = _SIMOrderRepository.UpdateStatusOrder(
                model.status,
                model.orderIds,
                userId
            );
            return Json(result.Message);
        }

        // POST: SIMOrderController/Delete/5
        [HttpGet]
        [Authorize(Roles = "Xóa đơn hỏi mua")]
        public ActionResult Delete(int id)
        {
            try
            {
                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _SIMOrderRepository.DeleteSIMOrder(id, userId);

                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, result.Message);
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // POST: SIMOrderController/Delete/5
        [HttpGet]
        [Authorize(Roles = "Xóa phiếu xuất sim")]
        public ActionResult DeletePXS(int id)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                ClaimTypes.NameIdentifier
            );
            var result = _goodsDeliveryNoteOfSimRepository.Delete(id, new Guid(userId));
            return Json(result);
        }

        // GET: SIMOrderController/Edit/5
        [Route("xuat-sim")]
        [Authorize(Roles = "Xuất sim")]
        public ActionResult XuatSim(string orderIds)
        {
            var orderInfo = _SIMOrderRepository.GetOrderInfoInDebt(orderIds);
            RequestGetSimInfoInOrderModel request = new()
            {
                customerId = orderInfo.agentId.ToString(),
                simIds = string.Join(",", orderInfo.simInfoInDebts.Select(x => x.Id).ToArray()),
                orderIds = orderIds,
            };
            var simInOrderInfo = _SIMRepository.GetSIMInOrder(request);
            ViewBag.SimInOrderInfo = simInOrderInfo;
            @ViewBag.OrderInfos = orderInfo;
            @ViewBag.AgentInfo = _AccountRepository.GetUserForEdit(orderInfo.agentId ?? new Guid());
            @ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
            @ViewBag.Staffs = _AccountRepository.GetStaffForCombo();
            @ViewBag.DeliveryAgents = _AccountRepository.GetAgentForCombo();
            @ViewBag.FormOfDelivery = _SIMOrderRepository.GetFormOfDeliveryForComb();
            @ViewBag.Banks = _bankRepository.GetBankForCombo();
            @ViewBag.ShippingUnits = _shippingUnitRepository.GetShippingUnitForCombo();
            List<SelectListItem> payOrderSelectedItems = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = PaymentType.COD.ToString(),
                    Text = "Thanh toán tiền mặt",
                    Selected = true,
                },
                new SelectListItem()
                {
                    Value = PaymentType.Online.ToString(),
                    Text = "Thanh toán online",
                },
                new SelectListItem()
                {
                    Value = PaymentType.Company.ToString(),
                    Text = "Xuất hóa đơn công ty",
                },
                new SelectListItem()
                {
                    Value = PaymentType.Installment.ToString(),
                    Text = "Thanh toán trả góp",
                },
            };
            @ViewBag.PayOrderType = payOrderSelectedItems;
            List<SelectListItem> typePriceSimOrder = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.Defaul.ToString(),
                    Text = "Giá bán lẻ",
                    Selected = true,
                },
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.ForAgent.ToString(),
                    Text = "Giá cho đại lý",
                },
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.ForCollaborators.ToString(),
                    Text = "Giá cho cộng tác viên",
                },
            };
            @ViewBag.TypePriceSimOrder = typePriceSimOrder;

            var sysConfig = _systemConfigRepository.GetInstallmentSimConfig();
            @ViewBag.DailyInterestRate = sysConfig.Installment_DailyInterestRate;
            @ViewBag.MinimumPaymentRate = sysConfig.Installment_MinimumPaymentRate;
            var agentInfo = _AccountRepository.GetUserForEdit(orderInfo.agentId ?? new Guid());
            var dataNew = new GoodsDeliveryNoteOfSimModel();
            dataNew.OldDebt = agentInfo.OldDebt ?? 0;
            dataNew.CustomerId = orderInfo.agentId ?? new Guid();
            dataNew.OrderIds = orderIds;
            dataNew.OrderPrice =
                simInOrderInfo.totalOrderPrice
                + simInOrderInfo.totalSimServiceFee
                + simInOrderInfo.totalSimEmbryoFee;
            ViewBag.TotalPriceOfSim =
                simInOrderInfo.totalOrderPrice
                + simInOrderInfo.totalSimServiceFee
                + simInOrderInfo.totalSimEmbryoFee;
            dataNew.SimInfosInOrders = new();
            dataNew.PayOrderType = orderInfo.orderInDebts[0].PaymentType;
            if (orderInfo.orderInDebts[0].PaymentType == PaymentType.Installment)
                dataNew.OrderPrice = orderInfo.orderInDebts[0].PriceOrder ?? 0;
            dataNew.InstallmentPeriod = orderInfo.orderInDebts[0].InstallmentPeriod;
            dataNew.DownPayment = orderInfo.orderInDebts[0].DownPayment ?? 0;
            dataNew.InstallmentPayment = orderInfo.orderInDebts[0].InstallmentPayment ?? 0;
            dataNew.MonthlyInstallmentPayment =
                orderInfo.orderInDebts[0].MonthlyInstallmentPayment ?? 0;
            dataNew.InterestRate = orderInfo.orderInDebts[0].InterestRate ?? 0;
            dataNew.CreateTime = DateTime.Now;
            dataNew.DeliveryDate = DateTime.Now;
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                ClaimTypes.NameIdentifier
            );
            dataNew.CreateBy = new Guid(userId);
            foreach (var sim in simInOrderInfo.simInfos)
            {
                dataNew.SimInfosInOrders.Add(
                    new SimInfosInOrderModel()
                    {
                        OrderId = sim.orderId,
                        SimId = sim.id,
                        SimNumber = sim.number ?? "",
                        PriceOfSim = sim.price,
                        DiscountOfSim = sim.discountOrder,
                        PriceOfDiscount = sim.priceDiscountOrder,
                        PriceAfterDiscount = sim.priceOrder,
                        SimSeria = sim.seria,
                        SimEmbryoFee = sim.simEmbryoFee,
                        SimServiceFee = sim.simServiceFee,
                        AgentId = sim.ownerId,
                        AgentName = sim.owner,
                        PriceOfAgent = sim.SIMPriceOfAgent,
                        DiscountOfAgent = sim.discountForMe,
                        PriceOfDiscountAgent = sim.priceDiscountForMe,
                        PriceAfterDiscountAgent = sim.priceForMe,
                    }
                );
            }
            return View(dataNew);
        }

        // POST: SIMOrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("xuat-sim")]
        [Authorize(Roles = "Xuất sim")]
        public ActionResult XuatSim(GoodsDeliveryNoteOfSimModel request)
        {
            try
            {
                var orderInfo = _SIMOrderRepository.GetOrderInfoInDebt(request.OrderIds);
                RequestGetSimInfoInOrderModel requestSimInfo = new()
                {
                    customerId = orderInfo.agentId.ToString(),
                    simIds = string.Join(",", orderInfo.simInfoInDebts.Select(x => x.Id).ToArray()),
                };
                var simInOrderInfo = _SIMRepository.GetSIMInOrder(requestSimInfo);
                request.ListSimNumberInOrder = string.Join(
                    "\n",
                    simInOrderInfo.simInfos.Select(x => x.number).ToArray()
                );
                request.CustomerId = orderInfo.agentId;
                ViewBag.SimInOrderInfo = simInOrderInfo;
                @ViewBag.OrderInfos = orderInfo;
                var agentInfo = _AccountRepository.GetUserForEdit(orderInfo.agentId ?? new Guid());
                @ViewBag.AgentInfo = agentInfo;
                @ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
                @ViewBag.Staffs = _AccountRepository.GetStaffForCombo();
                @ViewBag.DeliveryAgents = _AccountRepository.GetAgentForCombo();
                @ViewBag.FormOfDelivery = _SIMOrderRepository.GetFormOfDeliveryForComb();
                @ViewBag.Banks = _bankRepository.GetBankForCombo();
                @ViewBag.ShippingUnits = _shippingUnitRepository.GetShippingUnitForCombo();
                List<SelectListItem> payOrderSelectedItems = new List<SelectListItem>()
                {
                    new SelectListItem()
                    {
                        Value = PaymentType.COD.ToString(),
                        Text = "Thanh toán tiền mặt",
                        Selected = true,
                    },
                    new SelectListItem()
                    {
                        Value = PaymentType.Online.ToString(),
                        Text = "Thanh toán online",
                    },
                    new SelectListItem()
                    {
                        Value = PaymentType.Company.ToString(),
                        Text = "Xuất hóa đơn công ty",
                    },
                    new SelectListItem()
                    {
                        Value = PaymentType.Installment.ToString(),
                        Text = "Thanh toán trả góp",
                    },
                };
                @ViewBag.PayOrderType = payOrderSelectedItems;
                List<SelectListItem> typePriceSimOrder = new List<SelectListItem>()
                {
                    new SelectListItem()
                    {
                        Value = TypePriceSimOrder.Defaul.ToString(),
                        Text = "Giá bán lẻ",
                        Selected = true,
                    },
                    new SelectListItem()
                    {
                        Value = TypePriceSimOrder.ForAgent.ToString(),
                        Text = "Giá cho đại lý",
                    },
                    new SelectListItem()
                    {
                        Value = TypePriceSimOrder.ForCollaborators.ToString(),
                        Text = "Giá cho cộng tác viên",
                    },
                };
                @ViewBag.TypePriceSimOrder = typePriceSimOrder;
                var sysConfig = _systemConfigRepository.GetInstallmentSimConfig();
                @ViewBag.DailyInterestRate = sysConfig.Installment_DailyInterestRate;
                @ViewBag.MinimumPaymentRate = sysConfig.Installment_MinimumPaymentRate;
                if (!ModelState.IsValid)
                {
                    return View(request);
                }
                if (!agentInfo.IsAgent && request.TienDaThu == 0)
                {
                    ModelState.AddModelError(string.Empty, "Phải nhập tiền đã thu với khách lẻ");
                    return View(request);
                }
                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                //request.DebtCodePrefix = "PXSCN";
                var result = _goodsDeliveryNoteOfSimRepository.Create(request, userId);
                if (result.Code == "1")
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: SIMOrderController/Edit/5
        [Route("xem-phieuxuatsim")]
        [Authorize(Roles = "Xem phiếu xuất sim")]
        public ActionResult XuatSimDetail(int debtId)
        {
            var phieuXuatSim = _goodsDeliveryNoteOfSimRepository.Detail(debtId);
            var orderInfo = _SIMOrderRepository.GetOrderInfoInDebt(phieuXuatSim.OrderIds);
            RequestGetSimInfoInOrderModel requestSimInfo = new()
            {
                customerId = orderInfo.agentId.ToString(),
                simIds = string.Join(",", orderInfo.simInfoInDebts.Select(x => x.Id).ToArray()),
            };
            var simInOrderInfo = _SIMRepository.GetSIMInOrder(requestSimInfo);
            ViewBag.SimInOrderInfo = simInOrderInfo;
            @ViewBag.OrderInfos = orderInfo;
            @ViewBag.AgentInfo = _AccountRepository.GetUserForEdit(orderInfo.agentId ?? new Guid());
            @ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
            @ViewBag.Staffs = _AccountRepository.GetStaffForCombo();
            @ViewBag.DeliveryAgents = _AccountRepository.GetAgentForCombo();
            @ViewBag.FormOfDelivery = _SIMOrderRepository.GetFormOfDeliveryForComb();
            @ViewBag.Banks = _bankRepository.GetBankForCombo();
            @ViewBag.ShippingUnits = _shippingUnitRepository.GetShippingUnitForCombo();
            List<SelectListItem> payOrderSelectedItems = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = PaymentType.COD.ToString(),
                    Text = "Thanh toán tiền mặt",
                    Selected = true,
                },
                new SelectListItem()
                {
                    Value = PaymentType.Online.ToString(),
                    Text = "Thanh toán online",
                },
                new SelectListItem()
                {
                    Value = PaymentType.Company.ToString(),
                    Text = "Xuất hóa đơn công ty",
                },
                new SelectListItem()
                {
                    Value = PaymentType.Installment.ToString(),
                    Text = "Thanh toán trả góp",
                },
            };
            @ViewBag.PayOrderType = payOrderSelectedItems;
            List<SelectListItem> typePriceSimOrder = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.Defaul.ToString(),
                    Text = "Giá bán lẻ",
                    Selected = true,
                },
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.ForAgent.ToString(),
                    Text = "Giá cho đại lý",
                },
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.ForCollaborators.ToString(),
                    Text = "Giá cho cộng tác viên",
                },
            };
            @ViewBag.TypePriceSimOrder = typePriceSimOrder;
            var sysConfig = _systemConfigRepository.GetInstallmentSimConfig();
            @ViewBag.DailyInterestRate = sysConfig.Installment_DailyInterestRate;
            @ViewBag.MinimumPaymentRate = sysConfig.Installment_MinimumPaymentRate;
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                ClaimTypes.NameIdentifier
            );

            return View(phieuXuatSim);
        }

        // GET: SIMOrderController/Edit/5
        [Route("edit-xuatsim")]
        [Authorize(Roles = "Sửa phiếu xuất sim")]
        public ActionResult EditXuatSim(int debtId)
        {
            var phieuXuatSim = _goodsDeliveryNoteOfSimRepository.Detail(debtId);
            var orderInfo = _SIMOrderRepository.GetOrderInfoInDebt(phieuXuatSim.OrderIds);
            RequestGetSimInfoInOrderModel requestSimInfo = new()
            {
                customerId = orderInfo.agentId.ToString(),
                simIds = string.Join(",", orderInfo.simInfoInDebts.Select(x => x.Id).ToArray()),
            };
            var simInOrderInfo = _SIMRepository.GetSIMInOrder(requestSimInfo);
            ViewBag.SimInOrderInfo = simInOrderInfo;
            @ViewBag.OrderInfos = orderInfo;
            @ViewBag.AgentInfo = _AccountRepository.GetUserForEdit(orderInfo.agentId ?? new Guid());
            @ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
            @ViewBag.Staffs = _AccountRepository.GetStaffForCombo();
            @ViewBag.DeliveryAgents = _AccountRepository.GetAgentForCombo();
            @ViewBag.FormOfDelivery = _SIMOrderRepository.GetFormOfDeliveryForComb();
            @ViewBag.Banks = _bankRepository.GetBankForCombo();
            @ViewBag.ShippingUnits = _shippingUnitRepository.GetShippingUnitForCombo();
            List<SelectListItem> payOrderSelectedItems = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = PaymentType.COD.ToString(),
                    Text = "Thanh toán tiền mặt",
                    Selected = true,
                },
                new SelectListItem()
                {
                    Value = PaymentType.Online.ToString(),
                    Text = "Thanh toán online",
                },
                new SelectListItem()
                {
                    Value = PaymentType.Company.ToString(),
                    Text = "Xuất hóa đơn công ty",
                },
                new SelectListItem()
                {
                    Value = PaymentType.Installment.ToString(),
                    Text = "Thanh toán trả góp",
                },
            };
            @ViewBag.PayOrderType = payOrderSelectedItems;
            List<SelectListItem> typePriceSimOrder = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.Defaul.ToString(),
                    Text = "Giá bán lẻ",
                    Selected = true,
                },
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.ForAgent.ToString(),
                    Text = "Giá cho đại lý",
                },
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.ForCollaborators.ToString(),
                    Text = "Giá cho cộng tác viên",
                },
            };
            @ViewBag.TypePriceSimOrder = typePriceSimOrder;
            var sysConfig = _systemConfigRepository.GetInstallmentSimConfig();
            @ViewBag.DailyInterestRate = sysConfig.Installment_DailyInterestRate;
            @ViewBag.MinimumPaymentRate = sysConfig.Installment_MinimumPaymentRate;
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                ClaimTypes.NameIdentifier
            );

            return View(phieuXuatSim);
        } // POST: SIMOrderController/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-xuatsim")]
        [Authorize(Roles = "Sửa phiếu xuất sim")]
        public ActionResult EditXuatSim(GoodsDeliveryNoteOfSimModel request)
        {
            try
            {
                var orderInfo = _SIMOrderRepository.GetOrderInfoInDebt(request.OrderIds);
                RequestGetSimInfoInOrderModel requestSimInfo = new()
                {
                    customerId = orderInfo.agentId.ToString(),
                    simIds = string.Join(",", orderInfo.simInfoInDebts.Select(x => x.Id).ToArray()),
                };
                var simInOrderInfo = _SIMRepository.GetSIMInOrder(requestSimInfo);
                ViewBag.SimInOrderInfo = simInOrderInfo;
                @ViewBag.OrderInfos = orderInfo;
                var agentInfo = _AccountRepository.GetUserForEdit(orderInfo.agentId ?? new Guid());
                @ViewBag.AgentInfo = agentInfo;
                @ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
                @ViewBag.Staffs = _AccountRepository.GetStaffForCombo();
                @ViewBag.DeliveryAgents = _AccountRepository.GetAgentForCombo();
                @ViewBag.FormOfDelivery = _SIMOrderRepository.GetFormOfDeliveryForComb();
                @ViewBag.Banks = _bankRepository.GetBankForCombo();
                @ViewBag.ShippingUnits = _shippingUnitRepository.GetShippingUnitForCombo();
                List<SelectListItem> payOrderSelectedItems = new List<SelectListItem>()
                {
                    new SelectListItem()
                    {
                        Value = PaymentType.COD.ToString(),
                        Text = "Thanh toán tiền mặt",
                        Selected = true,
                    },
                    new SelectListItem()
                    {
                        Value = PaymentType.Online.ToString(),
                        Text = "Thanh toán online",
                    },
                    new SelectListItem()
                    {
                        Value = PaymentType.Company.ToString(),
                        Text = "Xuất hóa đơn công ty",
                    },
                    new SelectListItem()
                    {
                        Value = PaymentType.Installment.ToString(),
                        Text = "Thanh toán trả góp",
                    },
                };
                @ViewBag.PayOrderType = payOrderSelectedItems;
                var sysConfig = _systemConfigRepository.GetInstallmentSimConfig();
                @ViewBag.DailyInterestRate = sysConfig.Installment_DailyInterestRate;
                @ViewBag.MinimumPaymentRate = sysConfig.Installment_MinimumPaymentRate;
                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );

                if (!agentInfo.IsAgent && request.TienDaThu == 0)
                {
                    ModelState.AddModelError(string.Empty, "Phải nhập tiền đã thu với khách lẻ");
                    return View(request);
                }
                var result = _goodsDeliveryNoteOfSimRepository.Update(request, userId);
                if (result.Code == "1")
                {
                    return RedirectToAction("EditXuatSim", new { debtId = request.Id });
                }
                else
                {
                    ModelState.AddModelError(string.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ExportPhieuXuatSim(
            [FromBody] GoodsDeliveryNoteOfSimFilterRequest request
        )
        {
            var data = _goodsDeliveryNoteOfSimRepository.GetGoodsDeliveryNoteOfSimForFilter(
                request
            );

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Thông phiếu xuất";
            worksheet.Cell(1, 9).Value = "Thông tin bên mua";
            worksheet.Cell(1, 13).Value = "Thông tin bên GD hộ/ĐV Vận chuyển";
            worksheet.Cell(1, 16).Value = "Thông tin khác";

            worksheet.Cell(2, 1).Value = "Ngày tạo phiếu";
            worksheet.Cell(2, 2).Value = "Ngày lập phiếu";
            worksheet.Cell(2, 3).Value = "Mã phiếu";
            worksheet.Cell(2, 4).Value = "Số sim";
            worksheet.Cell(2, 5).Value = "Tổng đơn hàng";
            worksheet.Cell(2, 6).Value = "Tổng đã TT";
            worksheet.Cell(2, 7).Value = "Còn lại chưa TT";
            worksheet.Cell(2, 8).Value = "Ghi chú";
            worksheet.Cell(2, 9).Value = "Tên khách hàng";
            worksheet.Cell(2, 10).Value = "Số ĐT khách hàng";
            worksheet.Cell(2, 11).Value = "Địa chỉ khách hàng";
            worksheet.Cell(2, 12).Value = "Phí cộng trừ bên mua";
            worksheet.Cell(2, 13).Value = "Tên ĐV GD hộ";
            worksheet.Cell(2, 14).Value = "Tiền thu hộ/COD";
            worksheet.Cell(2, 15).Value = "Phí";
            worksheet.Cell(2, 16).Value = "Hình thức giao dịch";
            worksheet.Cell(2, 17).Value = "Người bán";
            worksheet.Cell(2, 18).Value = "Người lập";
            worksheet.Cell(2, 19).Value = "Trạng thái vận chuyển";
            worksheet.Cell(2, 20).Value = "Đã thu COD";
            worksheet.Cell(2, 21).Value = "Trạng thái";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 3, 1).Value = data.Data[i].CreateTime;
                worksheet.Cell(i + 3, 2).Value = data.Data[i].DeliveryDate;
                worksheet.Cell(i + 3, 3).Value = data.Data[i].Code;
                worksheet.Cell(i + 3, 4).Value = data.Data[i].ListSimNumberInOrder;
                worksheet.Cell(i + 3, 5).Value = data.Data[i].OrderPrice;
                worksheet.Cell(i + 3, 5).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 6).Value = data.Data[i].TienDaThu;
                worksheet.Cell(i + 3, 6).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 7).Value = data.Data[i].PhaiThuConLai;
                worksheet.Cell(i + 3, 7).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 8).Value = data.Data[i].Note;
                worksheet.Cell(i + 3, 9).Value = data.Data[i].CustomerName;
                worksheet.Cell(i + 3, 10).Value = data.Data[i].CustomerPhone;
                worksheet.Cell(i + 3, 11).Value = data.Data[i].CustomerAddress;
                worksheet.Cell(i + 3, 12).Value = data.Data[i].OtherFee;
                worksheet.Cell(i + 3, 12).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 13).Value = data.Data[i].ShippingName;
                worksheet.Cell(i + 3, 14).Value = data.Data[i].COD;
                worksheet.Cell(i + 3, 14).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 15).Value = data.Data[i].ShippingFee;
                worksheet.Cell(i + 3, 15).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 16).Value = data.Data[i].FormOfDeliveryId;
                worksheet.Cell(i + 3, 17).Value = data.Data[i].CreateBy;
                worksheet.Cell(i + 3, 18).Value = data.Data[i].ApprovedBy;
                worksheet.Cell(i + 3, 19).Value = data.Data[i].FlagCOD;
                worksheet.Cell(i + 3, 20).Value = data.Data[i].FlagThuHo;
                worksheet.Cell(i + 3, 21).Value = data.Data[i].approvedStatusStr;
            }

            var title1 = worksheet.Range("A1:G1");
            title1.Merge();
            var title2 = worksheet.Range("H1:K1");
            title2.Merge();
            var title3 = worksheet.Range("L1:N1");
            title3.Merge();
            var title4 = worksheet.Range("O1:S1");
            title4.Merge();

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(
                stream.ToArray(),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "export.xlsx"
            );
        }

        //
        public ActionResult GetSimIdsRandom([FromBody] RequestGetRandomSimIdsModel request)
        {
            var data = _SIMRepository.GetSimIdsRandom(request.simAmount, request.productTypeId);
            return Json(data);
        }

        //
        public FileResult DownloadOrderTemplate()
        {
            string path = Path.Combine(_environment.WebRootPath, "/Template/OrderSim.xlsx");
            return File(path, "application/vnd.ms-excel", "OrderSim.xlsx");
        }

        [HttpPost]
        [Route("read-order-file")]
        public async Task<ActionResult> ReadOrderFile(IFormFile file, string agentId)
        {
            var simIds = "";
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            if (file != null && file.Length > 0)
            {
                var uploadFileDirectory = $"{Directory.GetCurrentDirectory}/wwwroot/Uploads";
                if (!Directory.Exists(uploadFileDirectory))
                {
                    Directory.CreateDirectory(uploadFileDirectory);
                }
                var filePath = Path.Combine(uploadFileDirectory, file.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                List<ReadSimCSVModel> dataImport = new();
                using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        do
                        {
                            while (reader.Read())
                            {
                                ReadSimCSVModel readSimCSVModel = new ReadSimCSVModel();
                                //Sim number
                                if (reader.GetValue(0) != null)
                                    readSimCSVModel.phoneNumber = reader.GetValue(0).ToString();
                                else
                                    readSimCSVModel.phoneNumber = "";
                                //Seria
                                if (reader.GetValue(1) != null)
                                    readSimCSVModel.seria = reader.GetValue(1).ToString();
                                else
                                    readSimCSVModel.seria = "";

                                dataImport.Add(readSimCSVModel);
                            }
                        } while (reader.NextResult());
                    }
                }
                simIds = _SIMRepository.GetSimIdsWithDataInFile(dataImport, agentId);
                System.IO.File.Delete(filePath);
            }
            return Json(simIds);
        }

        //

        // GET: SIMOrderController/Edit/5
        [Route("ask-sim")]
        public ActionResult AskSim()
        {
            @ViewBag.SimIDs = "";
            @ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
            List<SelectListItem> payOrderSelectedItems = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = PaymentType.COD.ToString(),
                    Text = "Thanh toán tiền mặt",
                    Selected = true,
                },
                new SelectListItem()
                {
                    Value = PaymentType.Online.ToString(),
                    Text = "Thanh toán online",
                },
                new SelectListItem()
                {
                    Value = PaymentType.Company.ToString(),
                    Text = "Xuất hóa đơn công ty",
                },
                new SelectListItem()
                {
                    Value = PaymentType.Installment.ToString(),
                    Text = "Thanh toán trả góp",
                },
            };
            @ViewBag.PayOrderType = payOrderSelectedItems;
            List<SelectListItem> typePriceSimOrder = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.Defaul.ToString(),
                    Text = "Giá bán lẻ",
                    Selected = true,
                },
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.ForAgent.ToString(),
                    Text = "Giá cho đại lý",
                },
                new SelectListItem()
                {
                    Value = TypePriceSimOrder.ForCollaborators.ToString(),
                    Text = "Giá cho cộng tác viên",
                },
            };
            @ViewBag.TypePriceSimOrder = typePriceSimOrder;
            var sysConfig = _systemConfigRepository.GetInstallmentSimConfig();
            @ViewBag.DailyInterestRate = sysConfig.Installment_DailyInterestRate;
            @ViewBag.MinimumPaymentRate = sysConfig.Installment_MinimumPaymentRate;
            @ViewBag.Staffs = _AccountRepository.GetStaffForCombo();
            ViewBag.SPContacts = _contactConfigRepository.GetSPContactForCombo();
            @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();

            return View();
        }

        // POST: SIMOrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("ask-sim")]
        [Authorize(Roles = "Tạo mới đơn hỏi mua")]
        public ActionResult AskSim(SIMOrderModel request)
        {
            try
            {
                @ViewBag.SimInOrders = request.simInOrders;
                @ViewBag.SimIDs = string.Join(
                    ',',
                    request.simInOrders.Select(x => x.simId).ToList()
                );
                @ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
                @ViewBag.AgentInfo = _AccountRepository.GetUserForEdit(request.UserBuyId);
                request.UserId = new Guid(
                    _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier)
                );
                List<SelectListItem> payOrderSelectedItems = new List<SelectListItem>()
                {
                    new SelectListItem()
                    {
                        Value = PaymentType.COD.ToString(),
                        Text = "Thanh toán tiền mặt",
                        Selected = true,
                    },
                    new SelectListItem()
                    {
                        Value = PaymentType.Online.ToString(),
                        Text = "Thanh toán online",
                    },
                    new SelectListItem()
                    {
                        Value = PaymentType.Company.ToString(),
                        Text = "Xuất hóa đơn công ty",
                    },
                    new SelectListItem()
                    {
                        Value = PaymentType.Installment.ToString(),
                        Text = "Thanh toán trả góp",
                    },
                };
                List<SelectListItem> typePriceSimOrder = new List<SelectListItem>()
                {
                    new SelectListItem()
                    {
                        Value = TypePriceSimOrder.Defaul.ToString(),
                        Text = "Giá bán lẻ",
                        Selected = true,
                    },
                    new SelectListItem()
                    {
                        Value = TypePriceSimOrder.ForAgent.ToString(),
                        Text = "Giá cho đại lý",
                    },
                    new SelectListItem()
                    {
                        Value = TypePriceSimOrder.ForCollaborators.ToString(),
                        Text = "Giá cho cộng tác viên",
                    },
                };
                @ViewBag.TypePriceSimOrder = typePriceSimOrder;
                @ViewBag.PayOrderType = payOrderSelectedItems;
                var sysConfig = _systemConfigRepository.GetInstallmentSimConfig();
                @ViewBag.DailyInterestRate = sysConfig.Installment_DailyInterestRate;
                @ViewBag.MinimumPaymentRate = sysConfig.Installment_MinimumPaymentRate;
                @ViewBag.Staffs = _AccountRepository.GetStaffForCombo();
                ViewBag.SPContacts = _contactConfigRepository.GetSPContactForCombo();
                @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _SIMOrderRepository.CreateSIMOrder(request);
                if (result.Code == "1")
                {
                    //return RedirectToAction("AskSim", "SIMOrder");
                    return RedirectToAction("Edit", new { id = result.Data });
                }
                else
                {
                    ModelState.AddModelError(string.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
