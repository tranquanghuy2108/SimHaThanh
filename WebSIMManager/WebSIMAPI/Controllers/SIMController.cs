using Commons.Enums;
using Commons.Helper;
using EFCoreMySQL.EntityModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Repositories.Implement;
using Repositories.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSIMAPI.Controllers
{
    [Route("api/sim")]
    [ApiController]
    [AllowAnonymous]
    public class SIMController : ControllerBase
    {
        private readonly ISIMRepository _simRepository;
        private readonly IAppContentRepository _appContentRepository;
        private readonly ISIMOrderRepository _simOrderRepository;
        private readonly ISystemConfigRepository _systemConfigRepository;

        public SIMController(
            ISIMRepository repository,
            ISIMOrderRepository simOrderRepository,
            IAppContentRepository appContentRepository,
            ISystemConfigRepository systemConfigRepository
        )
        {
            _simRepository = repository;
            _simOrderRepository = simOrderRepository;
            _appContentRepository = appContentRepository;
            _systemConfigRepository = systemConfigRepository;
        }

        // GET: api/<SIMController>
        [HttpPost("search")]
        public List<SimOnAppModel> SearchSIM([FromBody] SearchSIMRequest request)
        {
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            if (request.pageSize == 0)
                request.pageSize = 50;

            return _simRepository.GetSIMAPI(request);
        }

        // GET: api/<SIMController>
        [HttpPost("search-sim-data")]
        public List<SimOnAppModel> SearchSIMDataOnApp([FromBody] SearchSIMDataOnAppRequest request)
        {
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            if (request.pageSize == 0)
                request.pageSize = 50;

            return _simRepository.GetSIMDataOnAppAPI(request).Data;
        }

        // GET: api/<SIMController>
        [HttpPost("search-sim-of-agent")]
        public List<SimOnAppModel> SearchSIMOfAgentOnApp(
            [FromBody] SearchSIMOfAgentOnAppRequest request
        )
        {
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            if (request.pageSize == 0)
                request.pageSize = 50;

            return _simRepository.GetSIMOfAgentOnAppAPI(request);
        }

        //
        [HttpPost("create-order")]
        public ResponseDataModel<int> CreateSimOrder([FromBody] SIMOrderModel request)
        {
            var result = _simOrderRepository.CreateSIMOrder(request);

            if (result.Code == "1")
            {
                var simInfo = _simRepository.GetSIMInfo(request.simInOrders.FirstOrDefault().simId);
                _ = TelegramHelper.SendMessage(
                    -4286160390,
                    "Sim số: " + simInfo.Number + " vừa được đặt qua app simhathanh"
                );
            }

            return result;
        }

        [HttpPost("create-order-in-cart")]
        public ResponseDataModel<int> CreateOrderInCart([FromBody] OrderSimInCart request)
        {
            ResponseDataModel<int> resp = new();
            SIMOrderModel model = new SIMOrderModel();
            List<SimInOrder> simIds = new();
            double simPrice = 0;
            double totalPrice = 0;
            List<int> ids = new();
            foreach (var item in request.ItemInCarts)
            {
                simPrice += item.Price * item.Qty;
                totalPrice += simPrice;
                if (item.Esim)
                    totalPrice += 50000;
                if (item.Type == SIMProductType.Normal)
                {
                    simIds.Add(
                        new()
                        {
                            simId = item.Id,
                            usingEsim = item.Esim,
                            simPrice = item.Price,
                        }
                    );
                }
                else
                {
                    ids = _simRepository.GetSimIdsRandom(item.Qty, item.Id);
                    if (ids.Count() <= 0)
                    {
                        resp.Code = "-2";
                        resp.Message =
                            "Không đủ sim "
                            + item.Name
                            + " để đặt hàng. Vui lòng kiểm tra lại giỏ hàng!";
                        return resp;
                    }
                    else
                    {
                        foreach (var simId in ids)
                        {
                            var simInfo = _simRepository.GetSIMInfo(simId);
                            simIds.Add(
                                new()
                                {
                                    simId = simId,
                                    usingEsim = item.Esim,
                                    simPrice = simInfo.Price,
                                }
                            );
                        }
                    }
                }
            }

            model.PriceOfSim = simPrice;
            model.PriceOrder = totalPrice;
            model.simInOrders = simIds;
            model.PhoneNum = request.CusPhone;
            model.Address = request.CusAddress + " - " + request.CusProvince;
            model.Note = "Đặt sim qua web (" + request.CusName + ") - " + request.CusNote;
            model.Name = request.CusName;
            model.UserBuyId = new Guid("08dc44ac-5797-4335-8ea0-3a97bd9a08e5");
            if (request.PaymentMethod == 0)
            {
                model.PaymentType = PaymentType.COD;
            }
            else
            {
                model.PaymentType = PaymentType.Online;
            }

            resp = _simOrderRepository.CreateSIMOrder(model);
            //if (resp.Code == "1")
            //    _ = TelegramHelper.SendMessage(
            //        -4286160390,
            //        "Sim số: "
            //            + string.Join(',', request.ItemInCarts.Select(x => x.Name).ToList())
            //            + " vừa được đặt qua web simhathanh.vn"
            //    );

            return resp;
        }

        [HttpPost("create-simdata-order")]
        public ResponseDataModel<int> CreateSimDataOrder([FromBody] OrderSIMDataOnHomeModel request)
        {
            SIMOrderModel model = new SIMOrderModel();
            List<SimInOrder> simInOrders = new List<SimInOrder>();
            if (String.IsNullOrEmpty(request.SimIds))
            {
                var simDataIds = _simRepository.GetSimIdsRandom(
                    request.Amount,
                    request.ProductTypeId
                );
                if (simDataIds.Count() <= 0)
                {
                    ResponseDataModel<int> resp = new();
                    resp.Code = "-2";
                    resp.Message = "Không đủ sim data để đặt hàng. Vui lòng kiểm tra lại!";
                    return resp;
                }
                else
                {
                    foreach (var simId in simDataIds)
                    {
                        var simInfo = _simRepository.GetSIMInfo(simId);
                        simInOrders.Add(
                            new SimInOrder()
                            {
                                simId = simId,
                                simPrice = simInfo.Price,
                                usingEsim = request.BuyEsim,
                            }
                        );
                    }
                }
            }
            var productType = _simRepository.GetProductTypeById(request.ProductTypeId);
            var Price = request.PriceOrder;
            model.simInOrders = simInOrders;
            model.PhoneNum = request.CusPhone;
            model.Address = request.CusAddress + " - " + request.CusProvince;
            model.Note = "Đặt sim qua app: (" + request.CusName + ") - " + request.CusNote;
            if (request.BuyEsim)
            {
                model.Note += " - Mua eSim";
                Price += request.Amount * 50000;
            }
            model.PriceOfSim = Price;
            model.PriceOrder = Price;
            model.UserBuyId = request.UserBuyId ?? new();
            model.Name = request.CusName;
            if (request.PaymentMethod == 0)
            {
                model.PaymentType = PaymentType.COD;
            }
            else
            {
                model.PaymentType = PaymentType.Online;
            }

            var result = _simOrderRepository.CreateSIMOrder(model);
            if (result.Code == "1")
                _ = TelegramHelper.SendMessage(
                    -4286160390,
                    "Sim " + productType.Name + " vừa được đặt qua app simhathanh"
                );

            return result;
        }

        //
        [HttpPost("cancel-order")]
        public ResponseDataModel<string> CancelSimOrder([FromBody] int id)
        {
            return _simOrderRepository.UpdateStatusOrder(
                Commons.Enums.StatusOrder.Cancel,
                id.ToString(),
                ""
            );
        }

        [HttpPost("all-orders-list")]
        public ResponseDataViewModel<SIMOrderViewAPIModel> GetOrdersList([FromBody] Guid userId)
        {
            return _simOrderRepository.GetSIMOrderApp(userId);
        }

        // GET api/<SIMController>
        [HttpGet("all-network-infos")]
        public List<SIMNetworkViewModel> GetNetworkInfos()
        {
            return _simRepository.GetSIMNetwork();
        }

        [HttpGet("all-simtype-infos")]
        public List<TypeOfSIMViewModel> GetSimTypekInfos()
        {
            return _simRepository.GetTypeOfSIM();
        }

        [HttpGet("sim-flash-sale")]
        public FlashSaleModel GetSimFlashSale()
        {
            return _appContentRepository.GetCurentFlashSale();
        }

        [HttpGet("sim-sale-on-day")]
        public List<SIMViewOnApp> GetSimSaleOnDay()
        {
            return _simRepository.GetSIMSaleOnDay();
        }

        [HttpGet("sim-last-update")]
        public List<SIMViewOnApp> GetSimLastUpdate()
        {
            return _simRepository.GetSIMLastUpdate();
        }

        [HttpGet("package-of-sim-data")]
        public List<ProductTypeModel> GetProductTypeOfSimData()
        {
            return _simRepository.GetProductTypeOfSimData();
        }

        [HttpGet("get-country")]
        public List<CountryModels> GetCountry()
        {
            return _systemConfigRepository.GetCountry().Data;
        }

        [HttpPost("sim-of-user")]
        public SimInfoOfUserModel GetSimInfoOfUser([FromBody] Guid userId)
        {
            return _simRepository.GetSimInfoOfUser(userId);
        }

        [HttpGet("get-data-sim")]
        public List<ProductTypeOfSimData> GetDataSim()
        {
            return _simOrderRepository.GetListSimData();
        }

        [HttpGet("get-tourist-sim")]
        public List<ProductTypeOfSimData> GetTouristSim()
        {
            return _simOrderRepository.GetListTouristSim();
        }
    }
}
