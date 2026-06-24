using System.Diagnostics;
using System.Numerics;
using System.Runtime;
using System.Text.RegularExpressions;
using Commons.Enums;
using Commons.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Memory;
using Models;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Repositories.Implement;
using Repositories.Interface;
using WebClient.Models;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISIMRepository _SIMRepository;
        private readonly ISIMOrderRepository _SIMOrderRepository;
        private readonly IContactRepository _contactRepository;
        private readonly INewsRepository _newsRepository;
        private readonly ILogger<HomeController> _logger;
        private readonly IMemoryCache _memoryCache;
        string device_info = string.Empty;
        bool IsMobile = false;

        public HomeController(
            ISIMRepository SIMRepository,
            ISIMOrderRepository SIMOrderRepository,
            IContactRepository contactRepository,
            INewsRepository newsRepository,
            ILogger<HomeController> logger,
            IMemoryCache memoryCache
        )
        {
            _SIMRepository = SIMRepository;
            _SIMOrderRepository = SIMOrderRepository;
            _contactRepository = contactRepository;
            _newsRepository = newsRepository;
            _logger = logger;
            _memoryCache = memoryCache;
        }

        // GET: SIMController
        public ActionResult Index(SearchSIMRequest request)
        {
            ViewBag.UseNavMenu = false;
            CheckIsMobileBrower();
            return View();
        }

        [Route("sim-so-dep")]
        public ActionResult SimCard(SearchSIMRequest request)
        {
            //
            request.keyword = "";
            request.isPaged = true;
            request.sortBy = SortBy.Normal;
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageSize = 60;

            //simkhuyenmai
            request.priceFrom = 0;
            request.priceTo = 0;
            var simKhuyenMai = _SIMRepository.GetSIMOnHome(request);
            if (simKhuyenMai != null)
            {
                @ViewBag.SimKhuyenMai = simKhuyenMai.Data;
            }
            //simsodep
            request.simTypeIds = new() { 3, 7 };
            var simSoDep = _SIMRepository.GetSIMOnHome(request);
            if (simSoDep != null)
            {
                @ViewBag.SimSoDep = simSoDep.Data;
            }

            //simtragop
            request.simTypeIds = new();
            request.priceFrom = 10000000;
            request.priceTo = 999999999999;
            var simTraGop = _SIMRepository.GetSIMOnHome(request);
            if (simTraGop != null)
            {
                @ViewBag.SimTraGop = simTraGop.Data;
            }
            GetNavMenuInfo();
            return View();
        }

        public ActionResult SearchOnHome(SearchSIMRequest request)
        {
            if (request.keyword == null)
                request.keyword = "";
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageSize = 50;
            var data = _SIMRepository.GetSIMOnHomePaging(request);
            if (data != null)
            {
                @ViewBag.DataView = data.Data;
                @ViewBag.Pager = data.Pager;
            }
            GetNavMenuInfo();
            //simsodep
            request = new SearchSIMRequest();
            request.keyword = "";
            request.pageIndex = 1;
            request.pageSize = 50;
            request.simTypeIds = new() { 3, 7 };
            var simSoDep = _SIMRepository.GetSIMOnHomePaging(request);
            if (simSoDep != null)
            {
                @ViewBag.SimSoDep = simSoDep.Data;
            }
            return View();
        }

        //[Route("tim-kiem-sim-so-dep")]
        //[HttpPost]
        [Route("{searchType}_{slug:regex(^[[a-z0-9()*\\-]]{{2,50}}$)}")]
        public ActionResult Search(SearchType searchType, string slug)
        {
            ViewBag.SearchType = (int)searchType;
            ViewBag.Slug = slug;
            GetNavMenuInfo();
            return View();
        }

        public ActionResult TimSim([FromBody] TimSimRequest timSimRequest)
        {
            SearchSIMRequest request = new();
            if (request.keyword == null)
                request.keyword = "";
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageIndex = timSimRequest.pageIndex;
            request.pageSize = timSimRequest.pageSize;
            request.networkIds = new();
            request.simTypeIds = new();
            request.priceFrom = 0;
            request.priceTo = 0;

            switch (timSimRequest.searchType)
            {
                case SearchType.gia:
                    var priceFrom = Int32.Parse(
                        timSimRequest
                            .keyword.Substring(0, timSimRequest.keyword.IndexOf("den"))
                            .Replace("-", "")
                            .Replace("tu", "")
                    );
                    var priceTo = Int32.Parse(
                        timSimRequest
                            .keyword.Substring(timSimRequest.keyword.IndexOf("den"))
                            .Replace("den", "")
                            .Replace("-", "")
                    );
                    request.priceFrom = priceFrom;
                    request.priceTo = priceTo;
                    break;
                case SearchType.namsinh:
                    request.keyword = "*" + timSimRequest.keyword;
                    break;
                case SearchType.mang:
                    switch (timSimRequest.keyword.ToLower())
                    {
                        case "viettel":
                            request.networkIds.Add(1);
                            break;
                        case "vinaphone":
                            request.networkIds.Add(2);
                            break;
                        case "mobiphone":
                            request.networkIds.Add(3);
                            break;
                        case "vietnamobile":
                            request.networkIds.Add(4);
                            break;
                        case "gmobile":
                            request.networkIds.Add(5);
                            break;
                        case "itelecom":
                            request.networkIds.Add(6);
                            break;
                    }
                    break;
                case SearchType.loai:
                    var id = Int32.Parse(
                        timSimRequest
                            .keyword.Substring(timSimRequest.keyword.IndexOf("("))
                            .Replace("(", "")
                            .Replace(")", "")
                    );
                    request.simTypeIds.Add(id);
                    break;
                case SearchType.sosim:
                    request.keyword = timSimRequest.keyword;
                    break;
                case SearchType.dauso:
                    request.keyword = timSimRequest.keyword + "*";
                    break;
            }

            var data = _SIMRepository.GetSIMOnHomePaging(request);
            if (data != null)
            {
                @ViewBag.DataView = data.Data;
                @ViewBag.Pager = data.Pager;
            }
            return Json(data);
        }

        private void GetNavMenuInfo()
        {
            GetPagingRequest request = new GetPagingRequest()
            {
                keyword = "",
                pageIndex = 1,
                pageSize = 200,
            };
            //
            ViewBag.SIMNetworks = _SIMRepository.GetSIMNetworkPaging(request).Data;
            //
            ViewBag.SPContacts = _contactRepository.GetSPContactPaging(request).Data;
            //
            request.pageSize = 10;
            GetPagingRequest orderRequest = new GetPagingRequest()
            {
                pageIndex = 1,
                pageSize = 10,
                keyword = "",
            };
            ViewBag.SIMOrders = _SIMOrderRepository.GetSIMOrderOnHomePaging(orderRequest).Data;
            //
            request.pageSize = 5;
            ViewBag.News = _newsRepository.GetNewPaging(request).Data;
            CheckIsMobileBrower();
            ViewBag.UseNavMenu = true;
        }

        private void CheckIsMobileBrower()
        {
            //
            var browserinfo = new Browser()
            {
                userAgent = Request.Headers["User-Agent"].ToString(),
                OS = new Regex(
                    @"(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino",
                    RegexOptions.IgnoreCase | RegexOptions.Multiline
                ),
                device = new Regex(
                    @"1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-",
                    RegexOptions.IgnoreCase | RegexOptions.Multiline
                ),
            };
            if (browserinfo.OS.IsMatch(browserinfo.userAgent))
            {
                device_info = browserinfo.OS.Match(browserinfo.userAgent).Groups[0].Value;
            }
            if (browserinfo.device.IsMatch(browserinfo.userAgent.Substring(0, 4)))
            {
                device_info += browserinfo.device.Match(browserinfo.userAgent).Groups[0].Value;
            }
            if (!string.IsNullOrEmpty(device_info))
            {
                IsMobile = true;
            }
            ViewBag.IsMobile = IsMobile;
        }

        [Route("sim-phong-thuy")]
        public IActionResult FengShui()
        {
            GetNavMenuInfo();
            return View();
        }

        [HttpPost]
        public IActionResult XemDiemSim([FromBody] XemDiemSimRequestModel request)
        {
            XemDiemSimrResponseModel diemSim = new();
            diemSim.BirthDay =
                request.dateOfBirth + "/" + request.monthOfBirth + "/" + request.yearOfBirth;
            var lunarBirthDay = SimPhongThuy.GetDateOfChinese(
                request.yearOfBirth,
                request.monthOfBirth,
                request.dateOfBirth
            );
            diemSim.LunarBirthDay = lunarBirthDay.ToString("dd/MM/yyyy");
            var menhchu = SimPhongThuy.GetUserFengShuiInfo(lunarBirthDay.Year);
            diemSim.menhchu = menhchu;
            diemSim.amDuongTuongPhoi = SimPhongThuy.GetAmDuongTuongPhoi(
                request.simNumber,
                menhchu.CanChi,
                request.isMale
            );
            diemSim.nguHanhSim = SimPhongThuy.GetNguHanhSim(request.simNumber, menhchu.NguHanh);
            diemSim.queBatQuai = SimPhongThuy.GetQueBatQuaiInfo(request.simNumber);
            float pointCuuTinhDo = 0;
            if (request.simNumber.Contains("9"))
                pointCuuTinhDo += 2;
            else
                pointCuuTinhDo += 1;
            diemSim.pointCuuTinhDo = pointCuuTinhDo;
            diemSim.quanNiemDanGian = SimPhongThuy.GetQuanNiemDanGianInfo(request.simNumber);

            return Json(diemSim);
        }

        [Route("sim-tra-gop")]
        public IActionResult Installment(SearchSIMRequest request)
        {
            if (request.keyword == null)
                request.keyword = "simtragop";
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageSize = 0;
            //request.searchType = SearchType.SimType;
            var data = _SIMRepository.GetSIMOnHomePaging(request);
            if (data != null)
            {
                @ViewBag.DataView = data.Data;
                @ViewBag.Pager = data.Pager;
            }
            GetNavMenuInfo();
            return View();
        }

        [Route("sim-du-lich")]
        public IActionResult TouristSim()
        {
            GetNavMenuInfo();
            ViewBag.TouristSims = _SIMOrderRepository.GetListTouristSim();
            return View();
        }

        [Route("sim-data")]
        public IActionResult DataSim()
        {
            GetNavMenuInfo();
            ViewBag.SimData = _SIMOrderRepository.GetListSimData();
            ViewBag.ProductTypes = _SIMRepository.GetProductTypeSIMDataForCombo();
            return View();
        }

        public ActionResult SearchSIMData([FromBody] SearchSIMDataOnAppRequest request)
        {
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            if (request.pageSize == 0)
                request.pageSize = 50;

            var result = _SIMRepository.GetSIMDataOnAppAPI(request);
            return Json(result);
        }

        [Route("tim-sim-phong-thuy")]
        public IActionResult SearchFengShui()
        {
            GetNavMenuInfo();
            return View();
        }

        public IActionResult TimSimPhongThuy([FromBody] TimSimPhongThuyRequestModel request)
        {
            TimSimPhongThuyResponseModel result = new();
            var lunarBirthDay = SimPhongThuy.GetDateOfChinese(
                request.yearOfBirth,
                request.monthOfBirth,
                request.dateOfBirth
            );
            result.BirthDay =
                request.dateOfBirth + "/" + request.monthOfBirth + "/" + request.yearOfBirth;
            result.LunarBirthDay = lunarBirthDay.ToString("dd/MM/yyyy");
            var menhchu = SimPhongThuy.GetUserFengShuiInfo(lunarBirthDay.Year);
            result.menhchu = menhchu;
            var amDuong = SimPhongThuy.GetMenhAmDuong(menhchu.CanChi, request.isMale);
            result.simPhongThuys = new();
            var simPTs = _SIMRepository.GetSimPTOfMenhChu(
                amDuong.Substring(0, amDuong.IndexOf(" ")),
                menhchu.NguHanh,
                request.pageIndex,
                request.pageSize
            );
            result.simPhongThuys = simPTs;
            //var simPT =
            return Json(result);
        }

        [Route("dinh-gia-sim")]
        public IActionResult SIMpricing()
        {
            GetNavMenuInfo();
            return View();
        }

        public IActionResult DinhGiaSim([FromBody] DinhGiaSimRequestModel request)
        {
            var simNumber = request.simNumber.Replace(".", "");
            var formatSimLst = FileHelper.CheckFormatTypeOfSim(simNumber, out _);
            var estimatePrice = _SIMRepository.GetEstimatedPrice(formatSimLst);
            double pricePT = 300000;
            var diemSim = SimPhongThuy.TinhDiemPhongThuy(simNumber);
            if (diemSim.point > 8)
                pricePT = 800000;
            if (pricePT >= estimatePrice)
                return Json(pricePT.ToString("#,##0"));
            else
                return Json(estimatePrice.ToString("#,##0"));
        }

        [Route("thanh-toan")]
        public IActionResult Payment()
        {
            GetNavMenuInfo();
            return View();
        }

        [Route("lien-he")]
        public IActionResult Contact()
        {
            GetNavMenuInfo();
            return View();
        }

        [Route("tin-tuc")]
        public IActionResult News()
        {
            GetNavMenuInfo();
            GetPagingRequest request = new GetPagingRequest()
            {
                keyword = "",
                pageIndex = 1,
                pageSize = 20,
            };
            @ViewBag.NewsPaging = _newsRepository.GetNewsOnHomePaging(request).Data;
            return View();
        }

        [Route("chi-tiet/{id}")]
        public IActionResult NewsDetail(int id)
        {
            GetNavMenuInfo();
            GetPagingRequest request = new GetPagingRequest()
            {
                keyword = "",
                pageIndex = 1,
                pageSize = 20,
            };
            var data = _newsRepository.GetNewDetail(id);
            ViewBag.NewsDetail = data;
            return View();
        }

        [Route("p/{slug:regex(^[[a-z\\-]]{{2,50}}$)}")]
        public IActionResult NewsDetail(string slug)
        {
            GetNavMenuInfo();
            GetPagingRequest request = new GetPagingRequest()
            {
                keyword = "",
                pageIndex = 1,
                pageSize = 20,
            };
            var data = _newsRepository.GetNewDetail(slug);
            ViewBag.NewsDetail = data;
            return View();
        }

        // GET: SIMController/Create
        [Route("buy-sim")]
        public ActionResult CreateOrder(int id)
        {
            GetNavMenuInfo();
            var simInfo = _SIMRepository.GetSIMInfo(id);
            @ViewBag.SimInfo = simInfo;
            var simTypes = simInfo.SIMType;
            ViewBag.SimTypes = string.Join(",", simTypes.Distinct());
            List<SelectListItem> selectListItems = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = PaymentType.COD.ToString(),
                    Text = "Thanh toán khi nhận hàng",
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
            };
            @ViewBag.PayOrderType = selectListItems;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateSimOrder([FromBody] OrderSIMOnHomeModel request)
        {
            // Basic Origin/Referer check (if provided)
            var origin =
                Request.Headers["Origin"].FirstOrDefault()
                ?? Request.Headers["Referer"].FirstOrDefault();
            if (!string.IsNullOrEmpty(origin) && !origin.Contains(Request.Host.Host))
            {
                _logger.LogWarning(
                    "Blocked CreateSimOrder due to invalid origin: {origin}",
                    origin
                );
                return Json(
                    new ResponseDataModel<int> { Code = "0", Message = "Invalid request origin." }
                );
            }

            // Simple rate-limiting per IP + simId (in-memory, short window)
            string ip = HttpContext.Connection.RemoteIpAddress?.ToString();
            if (string.IsNullOrEmpty(ip) && Request.Headers.ContainsKey("X-Forwarded-For"))
            {
                ip = Request
                    .Headers["X-Forwarded-For"]
                    .FirstOrDefault()
                    ?.Split(',')
                    .FirstOrDefault();
            }
            ip ??= "unknown";
            var key = $"order_attempts:{ip}:{request.SimId}";
            int attempts = 0;
            _memoryCache.TryGetValue<int>(key, out attempts);
            attempts++;
            if (attempts > 10)
            {
                _logger.LogWarning("Rate limit exceeded for IP {ip} sim {sim}", ip, request.SimId);
                return Json(
                    new ResponseDataModel<int>
                    {
                        Code = "0",
                        Message = "Quá nhiều yêu cầu. Vui lòng thử lại sau.",
                    }
                );
            }
            _memoryCache.Set<int>(key, attempts, TimeSpan.FromMinutes(1));

            SIMOrderModel model = new SIMOrderModel();
            var simInfo = _SIMRepository.GetSIMInfo(request.SimId);
            List<SimInOrder> simInOrders = new List<SimInOrder>();
            simInOrders.Add(
                new SimInOrder()
                {
                    simId = request.SimId,
                    simPrice = simInfo.Price,
                    usingEsim = request.UsingEsim,
                }
            );
            model.PriceOfSim = simInfo.Price;
            model.PriceOrder = simInfo.Price;
            model.simInOrders = simInOrders;
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

            var result = _SIMOrderRepository.CreateSIMOrder(model);
            if (result.Code == "1")
                await TelegramHelper.SendMessage(
                    -4286160390,
                    "Sim số: " + simInfo.Number + " vừa được đặt qua web simhathanh.vn"
                );

            return Json(result);
        }

        [Route("buy-sim-data")]
        public ActionResult CreateOrderSimData(int id, string simIds)
        {
            GetNavMenuInfo();
            var simProductTypeInfo = _SIMRepository.GetProductTypeById(id);
            @ViewBag.SimInfo = simProductTypeInfo;
            @ViewBag.SimIds = simIds;
            var simNumbers = string.Empty;
            var totalPrice = simProductTypeInfo.DefaulPrice;
            if (!string.IsNullOrEmpty(simIds))
            {
                var simIdsList = simIds.Split(',').Select(s => int.Parse(s)).ToList();
                var simInfos = _SIMRepository.GetSimInfoByIds(simIdsList).simInfos.ToList();
                simNumbers = string.Join(", ", simInfos.Select(x => x.Number).ToList());
                totalPrice = simInfos.Sum(x => x.Price);
            }
            @ViewBag.SimNumbers = simNumbers;
            @ViewBag.TotalPrices = totalPrice;
            List<SelectListItem> selectListItems = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = PaymentType.COD.ToString(),
                    Text = "Thanh toán khi nhận hàng",
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
            };
            @ViewBag.PayOrderType = selectListItems;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateSimDataOrder(
            [FromBody] OrderSIMDataOnHomeModel request
        )
        {
            GetNavMenuInfo();
            var simProductTypeInfo = _SIMRepository.GetProductTypeById(request.ProductTypeId);
            var simIds = request.SimIds;
            @ViewBag.SimIds = simIds;
            var simNumbers = string.Empty;
            var totalPrice = simProductTypeInfo.DefaulPrice;
            if (!string.IsNullOrEmpty(simIds))
            {
                var simIdsList = simIds.Split(',').Select(s => int.Parse(s)).ToList();
                var simInfos = _SIMRepository.GetSimInfoByIds(simIdsList).simInfos.ToList();
                simNumbers = string.Join(", ", simInfos.Select(x => x.Number).ToList());
                totalPrice = simInfos.Sum(x => x.Price);
            }
            @ViewBag.SimNumbers = simNumbers;
            @ViewBag.TotalPrices = totalPrice;

            List<SelectListItem> selectListItems = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = PaymentType.COD.ToString(),
                    Text = "Thanh toán khi nhận hàng",
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
            };
            @ViewBag.PayOrderType = selectListItems;

            SIMOrderModel model = new SIMOrderModel();
            List<SimInOrder> simInOrders = new List<SimInOrder>();
            if (String.IsNullOrEmpty(request.SimIds))
            {
                var simDataIds = _SIMRepository.GetSimIdsRandom(
                    request.Amount,
                    request.ProductTypeId
                );
                if (simDataIds.Count() <= 0)
                {
                    ResponseDataModel<string> resp = new();
                    resp.Code = "-2";
                    resp.Message = "Không đủ sim data để đặt hàng. Vui lòng kiểm tra lại!";
                    return Json(resp);
                }
                else
                {
                    foreach (var simId in simDataIds)
                    {
                        var simInfo = _SIMRepository.GetSIMInfo(simId);
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
            var productType = _SIMRepository.GetProductTypeById(request.ProductTypeId);
            var Price = request.PriceOrder;
            model.simInOrders = simInOrders;
            model.PhoneNum = request.CusPhone;
            model.Address = request.CusAddress + " - " + request.CusProvince;
            model.Note = "Đặt sim qua web (" + request.CusName + ") - " + request.CusNote;
            if (request.BuyEsim)
            {
                model.Note += " - Mua eSim";
            }
            model.PriceOfSim = Price;
            model.PriceOrder = Price;
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

            var result = _SIMOrderRepository.CreateSIMOrder(model);
            //if (result.Code == "1")
            //    await TelegramHelper.SendMessage(
            //        -4286160390,
            //        "Sim " + productType.Name + " vừa được đặt qua web simhathanh.vn"
            //    );

            return Json(result);
        }

        [Route("privacy")]
        public IActionResult Privacy()
        {
            GetNavMenuInfo();
            return View();
        }

        [Route("gio-hang")]
        public IActionResult Cart()
        {
            GetNavMenuInfo();
            return View();
        }

        public async Task<IActionResult> CreateOrderInCart([FromBody] OrderSimInCart request)
        {
            ResponseDataModel<int> resp = new();
            SIMOrderModel model = new SIMOrderModel();
            List<SimInOrder> simIds = new();
            double totalPrice = 0;
            List<int> ids = new();
            foreach (var item in request.ItemInCarts)
            {
                totalPrice += item.Price * item.Qty;
                if (item.Esim)
                    totalPrice += 50000 * item.Qty;
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
                    ids = _SIMRepository.GetSimIdsRandom(item.Qty, item.Id);
                    if (ids.Count() <= 0)
                    {
                        resp.Code = "-2";
                        resp.Message =
                            "Không đủ sim "
                            + item.Name
                            + " để đặt hàng. Vui lòng kiểm tra lại giỏ hàng!";
                        return Json(resp);
                    }
                    else
                    {
                        foreach (var simId in ids)
                        {
                            var simInfo = _SIMRepository.GetSIMInfo(simId);
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

            model.PriceOfSim = totalPrice;
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

            resp = _SIMOrderRepository.CreateSIMOrder(model);
            // if (resp.Code == "1")
            //     await TelegramHelper.SendMessage(
            //         -4286160390,
            //         "Sim số: "
            //             + string.Join(',', request.ItemInCarts.Select(x => x.Name).ToList())
            //             + " vừa được đặt qua web simhathanh.vn"
            //     );

            return Json(resp);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(
                new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                }
            );
        }
    }
}
