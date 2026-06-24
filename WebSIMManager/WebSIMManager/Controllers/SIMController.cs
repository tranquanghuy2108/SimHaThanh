using System.Security.Claims;
using Commons.Helper;
using Commons.Models;
using ExcelDataReader;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;
using Newtonsoft.Json;
using Repositories.Implement;
using Repositories.Interface;

namespace WebSIMManager.Controllers
{
    [Authorize]
    public class SIMController : BaseController
    {
        private readonly ISIMRepository _SIMRepository;
        private readonly IAccountRepository _AccountRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _environment;

        public SIMController(
            ISIMRepository SIMRepository,
            IAccountRepository accountRepository,
            IHttpContextAccessor httpContextAccessor,
            IWebHostEnvironment environment
        )
        {
            _SIMRepository = SIMRepository;
            _AccountRepository = accountRepository;
            _httpContextAccessor = httpContextAccessor;
            _environment = environment;
        }

        // GET: SIMController
        [Authorize(Roles = "Xem kho sim")]
        [Route("sim-nha")]
        public ActionResult Index()
        {
            @ViewBag.ProductTypes = _SIMRepository.GetSIMTypeForCombo();
            @ViewBag.Owners = _AccountRepository.GetStaffForCombo();
            @ViewBag.Networks = _SIMRepository.GetSIMNetworkListForCombo();
            return View();
        }

        [Authorize(Roles = "Xem kho sim")]
        [Route("sim-data")]
        public ActionResult SimData()
        {
            @ViewBag.ProductTypes = _SIMRepository.GetSIMDataNTouristForCombo();
            @ViewBag.Owners = _AccountRepository.GetStaffForCombo();
            @ViewBag.Networks = _SIMRepository.GetSIMNetworkListForCombo();
            return View();
        }

        public ActionResult SearchSIM([FromBody] SIMFilterModel request)
        {
            request.pageIndex = request.pageIndex == 0 ? 1 : request.pageIndex;
            request.pageSize = 50;

            var data = _SIMRepository.GetSIMPaging(request);
            return Json(data);
        }

        // GET: SIMController
        [Route("sim-dai-ly")]
        [Authorize(Roles = "Xem kho sim")]
        public ActionResult SimOfAgent()
        {
            @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
            @ViewBag.Owners = _AccountRepository.GetAgentAndAgentConsigmentForCombo();
            @ViewBag.Networks = _SIMRepository.GetSIMNetworkListForCombo();
            return View();
        }

        // GET: SIMController
        [Route("sim-dai-ly-ky-gui")]
        [Authorize(Roles = "Xem kho sim")]
        public ActionResult SimOfConsignmentAgent(string id)
        {
            @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
            @ViewBag.Owners = _AccountRepository.GetAgentConsigmentForCombo();
            @ViewBag.Networks = _SIMRepository.GetSIMNetworkListForCombo();
            @ViewBag.UserId = id;
            return View();
        }

        public FileResult DownloadTemplate()
        {
            string path = Path.Combine(_environment.WebRootPath, "/Template/UploadSim.xlsx");
            return File(path, "application/vnd.ms-excel", "UploadSim.xlsx");
        }

        [Route("import-sim")]
        [Authorize(Roles = "Import sim")]
        public ActionResult ImportCSV()
        {
            @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
            @ViewBag.Owners = _AccountRepository.GetCusAgentForCombo();
            @ViewBag.Networks = _SIMRepository.GetSIMNetworkListForCombo();
            return View();
        }

        [HttpPost]
        [Route("import-sim")]
        [Authorize(Roles = "Import sim")]
        public async Task<ActionResult> ImportCSV(IFormFile file)
        {
            @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
            @ViewBag.Owners = _AccountRepository.GetCusAgentForCombo();
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
                                if (reader.GetValue(0) != null)
                                    readSimCSVModel.phoneNumber = reader.GetValue(0).ToString();
                                else
                                    readSimCSVModel.phoneNumber = "";
                                //Price
                                double price = 0;
                                if (FileHelper.IsNumber(reader.GetValue(1)))
                                    price = Convert.ToDouble(reader.GetValue(1));
                                readSimCSVModel.price = price;
                                //PriceOfAgent
                                double priceOfAgent = 0;
                                if (FileHelper.IsNumber(reader.GetValue(2)))
                                    priceOfAgent = Convert.ToDouble(reader.GetValue(2));
                                readSimCSVModel.priceOfAgent = priceOfAgent;
                                //AgentSIMPrice
                                double AgentSIMPrice = 0;
                                if (FileHelper.IsNumber(reader.GetValue(3)))
                                    AgentSIMPrice = Convert.ToDouble(reader.GetValue(3));
                                readSimCSVModel.agentSIMPrice = AgentSIMPrice;
                                //CollaboratorsSIMPrice
                                double CollaboratorsSIMPrice = 0;
                                if (FileHelper.IsNumber(reader.GetValue(4)))
                                    CollaboratorsSIMPrice = Convert.ToDouble(reader.GetValue(4));
                                readSimCSVModel.collaboratorsSIMPrice = CollaboratorsSIMPrice;
                                //Seria
                                if (reader.GetValue(5) != null)
                                    readSimCSVModel.seria = reader.GetValue(5).ToString();
                                else
                                    readSimCSVModel.seria = "";
                                //Seria
                                if (reader.GetValue(6) != null)
                                    readSimCSVModel.position = reader.GetValue(6).ToString();
                                else
                                    readSimCSVModel.position = "";
                                //Product Type
                                if (reader.GetValue(7) != null)
                                {
                                    readSimCSVModel.productType = reader.GetValue(7).ToString();
                                }
                                else
                                {
                                    readSimCSVModel.productType = "Sim trả trước";
                                }
                                //Network
                                if (reader.GetValue(8) != null)
                                {
                                    readSimCSVModel.network = reader.GetValue(8).ToString();
                                }
                                else
                                {
                                    var phoneNumber = readSimCSVModel.phoneNumber;
                                    if (phoneNumber.Length > 9)
                                        phoneNumber = readSimCSVModel.phoneNumber.Substring(
                                            phoneNumber.Length - 9
                                        );
                                    readSimCSVModel.network = _SIMRepository.GetNetworkNameByPrefix(
                                        phoneNumber.Substring(0, 2)
                                    );
                                }
                                //description
                                if (reader.GetValue(9) != null)
                                {
                                    readSimCSVModel.description = reader.GetValue(9).ToString();
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
                var userActionId = new Guid(
                    _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier)
                );
                var importModel = new ImportSIMModel();
                importModel.Owner = request.Owner;
                importModel.DataInFile = JsonConvert.DeserializeObject<List<ReadSimCSVModel>>(
                    request.DataInFile
                );
                var result = await _SIMRepository.ImportSIM2(importModel, userActionId);
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

        // GET: SIMController/Create
        [Route("add-sim")]
        [Authorize(Roles = "Tạo mới sim")]
        public ActionResult Create()
        {
            @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
            @ViewBag.Owners = _AccountRepository.GetCusAgentForCombo();
            @ViewBag.Networks = _SIMRepository.GetSIMNetworkListForCombo();
            return View();
        }

        // POST: SIMController/Create
        [Route("add-sim")]
        [Authorize(Roles = "Tạo mới sim")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SIMCreateModel request)
        {
            @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
            @ViewBag.Owners = _AccountRepository.GetCusAgentForCombo();
            @ViewBag.Networks = _SIMRepository.GetSIMNetworkListForCombo();
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var userActionId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
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
        [Route("edit-sim")]
        [Authorize(Roles = "Sửa sim")]
        public ActionResult Edit(int id)
        {
            @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
            @ViewBag.Owners = _AccountRepository.GetCusAgentForCombo();
            @ViewBag.Networks = _SIMRepository.GetSIMNetworkListForCombo();
            var data = _SIMRepository.GetSIMDetail(id);
            return View(data);
        }

        // POST: SIMController/Edit/5
        [HttpPost]
        [Authorize(Roles = "Sửa sim")]
        [ValidateAntiForgeryToken]
        [Route("edit-sim")]
        public ActionResult Edit(SIMEditModel request)
        {
            try
            {
                @ViewBag.ProductTypes = _SIMRepository.GetProductTypeForCombo();
                @ViewBag.Owners = _AccountRepository.GetAgentForCombo();
                @ViewBag.Networks = _SIMRepository.GetSIMNetworkListForCombo();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var userActionId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
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

        // POST: SIMController/Delete/5
        [HttpGet]
        [Authorize(Roles = "Xóa sim")]
        public ActionResult Delete(int id)
        {
            try
            {
                var userActionId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _SIMRepository.DeleteSIM(id, userActionId ?? "");

                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // POST: SIMController/Delete/5
        [HttpGet]
        [Authorize(Roles = "Xóa sim")]
        public ActionResult DeleteAgentSIM(int id)
        {
            try
            {
                var userActionId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _SIMRepository.DeleteSIM(id, userActionId ?? "");

                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(SimOfAgent));
                }
                else
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // POST: SIMController/Delete/5
        [HttpGet]
        [Authorize(Roles = "Xóa sim")]
        public ActionResult DeleteAllMySIM()
        {
            var userActionId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                ClaimTypes.NameIdentifier
            );
            var result = _SIMRepository.DeleteAllMySIM(userActionId ?? "");
            return Json(result);
        }

        //[Authorize(Roles = "Duyệt sim đại lý")]
        public ActionResult OnApprovedSimOfAgent([FromBody] UpdateStatusSIMOfAgentRequest request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                ClaimTypes.NameIdentifier
            );
            var data = _SIMRepository.OnApprovedSimOfAgent(request, userId);
            return Json(data);
        }
    }
}
