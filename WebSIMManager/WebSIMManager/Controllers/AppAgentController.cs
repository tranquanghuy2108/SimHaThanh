using Commons.Enums;
using Commons.Helper;
using Commons.Models;
using ExcelDataReader;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.ViewModels;
using Newtonsoft.Json;
using Repositories.Implement;
using Repositories.Interface;
using System.Security.Claims;

namespace WebSIMManager.Controllers
{
    [Authorize]
    public class AppAgentController : Controller
    {
        private readonly ISIMRepository _SIMRepository;
        private readonly IAccountRepository _AccountRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _environment;
        private readonly ICollaboratorsGroupRepository _collaboratorsGroupRepository;
        public AppAgentController(ISIMRepository SIMRepository, 
            IAccountRepository accountRepository, 
            IHttpContextAccessor httpContextAccessor, 
            IWebHostEnvironment environment, 
            ICollaboratorsGroupRepository collaboratorsGroupRepository)
        {
            _SIMRepository = SIMRepository;
            _AccountRepository = accountRepository;
            _httpContextAccessor = httpContextAccessor;
            _environment = environment;
            _collaboratorsGroupRepository = collaboratorsGroupRepository;
        }
        // GET: AppAgentController
        public ActionResult Index(SearchSIMOfAgentOnAppRequest request)
        {
            List<SelectListItem> simsOnAppStatus = new List<SelectListItem>()
                {
                    new SelectListItem() { Value = SimOnAppStatus.All.ToString(),Text= "Tất cả", Selected = true},
                    new SelectListItem() { Value = SimOnAppStatus.OnSales.ToString(), Text= "Sim đang bán"},
                    new SelectListItem() { Value = SimOnAppStatus.WaitingApproved.ToString(), Text= "Sim chờ duyệt"},
                    new SelectListItem() { Value = SimOnAppStatus.Sold.ToString(), Text= "Sim đã bán"},
                };
            @ViewBag.SimsOnAppStatus = simsOnAppStatus;
            request.pageIndex = request.pageIndex == 0 ? 1 : request.pageIndex;
            if (request.keyword == null)
                request.keyword = "";
            else request.keyword = request.keyword.Replace(".", "");
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageSize = 50;
            if (request.simOnAppStatus == null) request.simOnAppStatus = SimOnAppStatus.All;
            request.userId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
            var data = _SIMRepository.GetSIMOfAgentOnCMS(request);
            if (data != null)
            {
                @ViewBag.DataView = data.Data;
                @ViewBag.Pager = data.Pager;
            }
            return View();
        }
        // GET: SIMController/Create
        [Route("add-sim-agent")]
        public ActionResult Create()
        {
            @ViewBag.Owner = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
            @ViewBag.Networks = _SIMRepository.GetSIMNetworkListForCombo();
            return View();
        }

        // POST: SIMController/Create
        [Route("add-sim-agent")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SIMCreateModel request)
        {
            @ViewBag.Owner = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
            @ViewBag.Networks = _SIMRepository.GetSIMNetworkListForCombo();
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var userActionId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = _SIMRepository.CreateSIM(request, userActionId ?? "");
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View(request);
            }
        }

        // GET: SIMController/Edit/5
        [Route("edit-sim-agent")]
        public ActionResult Edit(int id)
        {
            @ViewBag.Owner = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
            @ViewBag.Networks = _SIMRepository.GetSIMNetworkListForCombo();
            var data = _SIMRepository.GetSIMDetail(id);
            return View(data);
        }

        // POST: SIMController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-sim-agent")]
        public ActionResult Edit(SIMEditModel request)
        {
            try
            {
                @ViewBag.Owner = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
                @ViewBag.Networks = _SIMRepository.GetSIMNetworkListForCombo();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var userActionId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = _SIMRepository.UpdateSIM(request, userActionId ?? "");
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }


        public FileResult DownloadTemplate()
        {
            string path = Path.Combine(_environment.WebRootPath, "/Template/UploadSimAgent.xlsx");
            return File(path, "application/vnd.ms-excel", "UploadSimAgent.xlsx");
        }
        [Route("import-sim-agent")]
        public ActionResult ImportCSV()
        {
            @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
            @ViewBag.Networks = _SIMRepository.GetSIMNetworkListForCombo();
            return View();
        }
        [HttpPost]
        [Route("import-sim-agent")]
        public async Task<ActionResult> ImportCSV(IFormFile file)
        {
            @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
            @ViewBag.Networks = _SIMRepository.GetSIMNetworkListForCombo();
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
                                if (reader.GetValue(0) != null) readSimCSVModel.phoneNumber = reader.GetValue(0).ToString();
                                else readSimCSVModel.phoneNumber = "";
                                //Price
                                double price = 0;
                                if (FileHelper.IsNumber(reader.GetValue(1)))
                                    price = Convert.ToDouble(reader.GetValue(1));
                                readSimCSVModel.price = price;
                                readSimCSVModel.agentSIMPrice = price;
                                readSimCSVModel.collaboratorsSIMPrice = price;
                                //PriceOfAgent
                                double priceOfAgent = 0;
                                if (FileHelper.IsNumber(reader.GetValue(2)))
                                    priceOfAgent = Convert.ToDouble(reader.GetValue(2));
                                readSimCSVModel.priceOfAgent = priceOfAgent;
                                //Seria
                                if (reader.GetValue(3) != null) readSimCSVModel.seria = reader.GetValue(3).ToString();
                                else readSimCSVModel.seria = "";
                                //Seria
                                if (reader.GetValue(4) != null) readSimCSVModel.position = reader.GetValue(4).ToString();
                                else readSimCSVModel.position = "";
                                //Product Type
                                if (reader.GetValue(5) != null)
                                {
                                    readSimCSVModel.productType = reader.GetValue(5).ToString();
                                }
                                else
                                {
                                    readSimCSVModel.productType = "Sim trả trước";
                                }
                                //Network
                                if (reader.GetValue(6) != null)
                                {
                                    readSimCSVModel.network = reader.GetValue(6).ToString();
                                }
                                else
                                {
                                    readSimCSVModel.network = _SIMRepository.GetNetworkNameByPrefix(readSimCSVModel.phoneNumber.Substring(0, 2));
                                }
                                //description
                                if (reader.GetValue(7) != null)
                                {
                                    readSimCSVModel.description = reader.GetValue(7).ToString();
                                }
                                else
                                {
                                    readSimCSVModel.description = "";
                                }
                                dataImport.Add(readSimCSVModel);

                            }
                        } while (reader.NextResult());
                    }
                }
                ViewBag.CSVData = dataImport;
                System.IO.File.Delete(filePath);
            }
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> ImportSIM([FromBody] ImportSIMModel2 request)
        {
            try
            {
                var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var importModel = new ImportSIMModel();
                importModel.Owner = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                importModel.DataInFile = JsonConvert.DeserializeObject<List<ReadSimCSVModel>>(request.DataInFile);
                var result = await _SIMRepository.ImportSIM2(importModel, userActionId, true);
                if (result.Code == "1")
                {
                    return Json(result.Data);
                }
                else
                {
                    return Json(request.DataInFile);
                }
            }
            catch
            {
                return Json(request.DataInFile);
            }
        }
        #region AgentGroup
        [Route("agent-group-inapp")]
        public ActionResult AgentGroup(GetPagingRequest request)
        {
            request.keyword = request.keyword == null ? "" : request.keyword;
            request.pageIndex = request.pageIndex == 0 ? 1 : request.pageIndex;
            request.pageSize = 10;
            var userId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
            var data = _collaboratorsGroupRepository.GetMyGroup(userId);
            if (data != null)
            {
                @ViewBag.DataView = data.Data;
                @ViewBag.Pager = data.Pager;
            }
            return View();
        }
        // GET: UserController/Create
        [Route("add-agent-group-inapp")]
        public ActionResult AgentGroupCreate()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-agent-group-inapp")]
        public ActionResult AgentGroupCreate(CollaboratorsGroupEditModels models)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(models);
                }

                var userId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                models.OwnerId = userId;
                models.IsApp = true;
                models.IsForAgent = false;
                var result = _collaboratorsGroupRepository.Create(models);
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(AgentGroup));
                }
                else
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return View(models);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        [Route("edit-agent-group-inapp")]
        public ActionResult AgentGroupEdit(int id)
        {
            var editData = _collaboratorsGroupRepository.GetGroupById(id);
            return View(editData);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-agent-group-inapp")]
        public ActionResult AgentGroupEdit(CollaboratorsGroupEditModels models)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(models);
                }

                var userId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                models.OwnerId = userId;
                models.IsApp = true;
                models.IsForAgent = false;
                var result = _collaboratorsGroupRepository.Edit(models);

                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(AgentGroup));
                }
                else
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return View(models);
                }
            }
            catch
            {
                return View(models);
            }
        }
        [HttpGet]
        // POST: UserController/Delete/5
        public ActionResult AgentGroupDelete(int id)
        {
            try
            {
                var result = _collaboratorsGroupRepository.Delete(id);
                if (result.Code != "1")
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return Content("<script language='javascript' type='text/javascript'>alert('" + result.Message + "');</script>");
                }
                else
                    return RedirectToAction(nameof(AgentGroup));
            }
            catch
            {
                return RedirectToAction(nameof(AgentGroup));
            }
        }
        #endregion

    }
}
