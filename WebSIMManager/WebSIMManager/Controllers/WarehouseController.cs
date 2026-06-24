using System.Security.Claims;
using ClosedXML.Excel;
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
using Repositories.Implement;
using Repositories.Interface;

namespace WebSIMManager.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly IWarehouseRepository _warehouseRepository;
        private readonly ISIMRepository _simRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly ISIMOrderRepository _simOrderRepository;
        private readonly IBankRepository _bankRepository;
        private readonly IShippingUnitRepository _shippingUnitRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _environment;
        private readonly IDebtRepository _debtRepository;

        public WarehouseController(
            IWarehouseRepository warehouseRepository,
            IHttpContextAccessor httpContextAccessor,
            ISIMRepository simRepository,
            IAccountRepository accountRepository,
            ISIMOrderRepository simOrderRepository,
            IBankRepository bankRepository,
            IShippingUnitRepository shippingUnitRepository,
            IWebHostEnvironment environment
        )
        {
            _warehouseRepository = warehouseRepository;
            _httpContextAccessor = httpContextAccessor;
            _simRepository = simRepository;
            _accountRepository = accountRepository;
            _simOrderRepository = simOrderRepository;
            _bankRepository = bankRepository;
            _shippingUnitRepository = shippingUnitRepository;
            _environment = environment;
        }

        // GET: WarehouseController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        #region Material

        [Route("sim-seria")]
        public ActionResult MaterialWithSeriaInfo()
        {
            ViewBag.MateriaSeriaIds = _warehouseRepository.GetMaterialSeriaForCombo();
            return View();
        }

        [HttpPost]
        public ActionResult GetMaterialWithSeriaInfo(
            [FromBody] GetMateriaSeriaPagingRequest request
        )
        {
            try
            {
                var data = _warehouseRepository.GetMaterialWithSeriaInfo(request);
                return Json(data);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        public ActionResult ExportMaterialWithSeriaInfo(
            [FromBody] GetMateriaSeriaPagingRequest request
        )
        {
            var data = _warehouseRepository.GetMaterialWithSeriaInfo(request);
            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Mã phiếu nhập";
            worksheet.Cell(1, 2).Value = "Số sim";
            worksheet.Cell(1, 3).Value = "Seri sim";
            worksheet.Cell(1, 4).Value = "Vị trí";
            worksheet.Cell(1, 5).Value = "Loại sim";
            worksheet.Cell(1, 6).Value = "Trạng thái";
            worksheet.Cell(1, 7).Value = "Mã phiếu xuất";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = data.Data[i].grnCode;
                worksheet.Cell(i + 2, 2).Value = data.Data[i].Number;
                worksheet.Cell(i + 2, 3).Value = data.Data[i].Seria;
                worksheet.Cell(i + 2, 4).Value = data.Data[i].Position;
                worksheet.Cell(i + 2, 5).Value = data.Data[i].MaterialCode;
                worksheet.Cell(i + 2, 6).Value = data.Data[i].HadSelled ? "Đã bán" : "Chưa bán";
                worksheet.Cell(i + 2, 7).Value = data.Data[i].gdnCode;
            }

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

        public ActionResult GetMaterialInfo(int materialId)
        {
            var data = _warehouseRepository.GetMaterialDetail(materialId);
            return Json(data);
        }

        [Route("add-material")]
        [Authorize(Roles = "Tạo mặt hàng")]
        public ActionResult CreateMaterial()
        {
            ViewBag.DataTable = _warehouseRepository.GetListMaterial();
            ViewBag.Networks = _simRepository.GetSIMNetworkListForCombo();
            ViewBag.MaterialTypes = _warehouseRepository.GetMaterialTypeForCombo();
            ViewBag.MaterialGroups = _warehouseRepository.GetMaterialGroupForCombo();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-material")]
        [Authorize(Roles = "Tạo mặt hàng")]
        public ActionResult CreateMaterial(MaterialModel request)
        {
            try
            {
                ViewBag.DataTable = _warehouseRepository.GetListMaterial();
                ViewBag.Networks = _simRepository.GetSIMNetworkListForCombo();
                ViewBag.MaterialTypes = _warehouseRepository.GetMaterialTypeForCombo();
                ViewBag.MaterialGroups = _warehouseRepository.GetMaterialGroupForCombo();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _warehouseRepository.CreateMaterial(request, userId ?? "");
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(CreateMaterial));
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        [Route("edit-material")]
        [Authorize(Roles = "Sửa mặt hàng")]
        public ActionResult EditMaterial(int id)
        {
            ViewBag.DataTable = _warehouseRepository.GetListMaterial();
            ViewBag.Networks = _simRepository.GetSIMNetworkListForCombo();
            ViewBag.MaterialTypes = _warehouseRepository.GetMaterialTypeForCombo();
            ViewBag.MaterialGroups = _warehouseRepository.GetMaterialGroupForCombo();
            var materialDetail = _warehouseRepository.GetMaterialDetail(id);
            return View(materialDetail);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-material")]
        [Authorize(Roles = "Sửa mặt hàng")]
        public ActionResult EditMaterial(MaterialModel request)
        {
            try
            {
                ViewBag.DataTable = _warehouseRepository.GetListMaterial();
                ViewBag.Networks = _simRepository.GetSIMNetworkListForCombo();
                ViewBag.MaterialTypes = _warehouseRepository.GetMaterialTypeForCombo();
                ViewBag.MaterialGroups = _warehouseRepository.GetMaterialGroupForCombo();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _warehouseRepository.UpdateMaterial(request, userId ?? "");
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(CreateMaterial));
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        [Authorize(Roles = "Xóa mặt hàng")]
        public ActionResult DeleteMaterial(int id)
        {
            try
            {
                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _warehouseRepository.DeleteMaterial(id, userId ?? "");

                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(CreateMaterial));
                }
                else
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return RedirectToAction(nameof(CreateMaterial));
                }
            }
            catch
            {
                return RedirectToAction(nameof(CreateMaterial));
            }
        }
        #endregion
        #region MaterialGroup
        [Route("add-materialgroup")]
        [Authorize(Roles = "Tạo nhóm mặt hàng")]
        public ActionResult CreateMaterialGroup()
        {
            ViewBag.DataTable = _warehouseRepository.GetListMaterialGroup();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-materialgroup")]
        [Authorize(Roles = "Tạo nhóm mặt hàng")]
        public ActionResult CreateMaterialGroup(MaterialGroupModel request)
        {
            try
            {
                ViewBag.DataTable = _warehouseRepository.GetListMaterialGroup();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _warehouseRepository.CreateMaterialGroup(request, userId ?? "");
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(CreateMaterialGroup));
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        [Route("edit-materialgroup")]
        [Authorize(Roles = "Sửa nhóm mặt hàng")]
        public ActionResult EditMaterialGroup(int id)
        {
            ViewBag.DataTable = _warehouseRepository.GetListMaterialGroup();
            var materialGroupDetail = _warehouseRepository.GetMaterialGroupDetail(id);
            return View(materialGroupDetail);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-materialgroup")]
        [Authorize(Roles = "Sửa nhóm mặt hàng")]
        public ActionResult EditMaterialGroup(MaterialGroupModel request)
        {
            try
            {
                ViewBag.DataTable = _warehouseRepository.GetListMaterialGroup();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _warehouseRepository.UpdateMaterialGroup(request, userId ?? "");
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(CreateMaterialGroup));
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        [Authorize(Roles = "Xóa nhóm mặt hàng")]
        public ActionResult DeleteMaterialGroup(int id)
        {
            try
            {
                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _warehouseRepository.DeleteMaterialGroup(id, userId ?? "");

                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(CreateMaterialGroup));
                }
                else
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return RedirectToAction(nameof(CreateMaterialGroup));
                }
            }
            catch
            {
                return RedirectToAction(nameof(CreateMaterialGroup));
            }
        }
        #endregion
        #region MaterialType
        [Route("add-materialtype")]
        [Authorize(Roles = "Tạo loại mặt hàng")]
        public ActionResult CreateMaterialType()
        {
            ViewBag.DataTable = _warehouseRepository.GetListMaterialType();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-materialtype")]
        [Authorize(Roles = "Tạo loại mặt hàng")]
        public ActionResult CreateMaterialType(MaterialTypeModel request)
        {
            try
            {
                ViewBag.DataTable = _warehouseRepository.GetListMaterialType();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _warehouseRepository.CreateMaterialType(request, userId ?? "");
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(CreateMaterialType));
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        [Route("edit-materialtype")]
        [Authorize(Roles = "Sửa loại mặt hàng")]
        public ActionResult EditMaterialType(int id)
        {
            ViewBag.DataTable = _warehouseRepository.GetListMaterialType();
            var materialTypeDetail = _warehouseRepository.GetMaterialTypeDetail(id);
            return View(materialTypeDetail);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-materialtype")]
        [Authorize(Roles = "Sửa loại mặt hàng")]
        public ActionResult EditMaterialType(MaterialTypeModel request)
        {
            try
            {
                ViewBag.DataTable = _warehouseRepository.GetListMaterialType();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _warehouseRepository.UpdateMaterialType(request, userId ?? "");
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(CreateMaterialType));
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        [Authorize(Roles = "Xóa loại mặt hàng")]
        public ActionResult DeleteMaterialType(int id)
        {
            try
            {
                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _warehouseRepository.DeleteMaterialType(id, userId ?? "");

                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(CreateMaterialType));
                }
                else
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return RedirectToAction(nameof(CreateMaterialType));
                }
            }
            catch
            {
                return RedirectToAction(nameof(CreateMaterialType));
            }
        }
        #endregion
        #region GoodsReceivedNote

        [Route("phieu-nhap-kho")]
        [Authorize(Roles = "Xem phiếu nhập kho")]
        public ActionResult GoodsReceivedNoteList()
        {
            ViewBag.Agents = _accountRepository.GetAgentForCombo();
            ViewBag.Staffs = _accountRepository.GetStaffForCombo();
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

        public ActionResult SearchGoodsReceivedNote(
            [FromBody] GoodsReceivedNoteFilterRequest request
        )
        {
            //request.userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = _warehouseRepository.GetListGoodsReceivedNote(request);
            return Json(data);
        }

        public ActionResult GetMaterialSeriaInGoodsReceivedNote(int id)
        {
            //request.userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = _warehouseRepository.GetMaterialSeriaInGoodsReceivedNote(id);
            return Json(data);
        }

        public ActionResult ApprovedGoodsReceivedNote([FromBody] ApprovedDebtRequest request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                ClaimTypes.NameIdentifier
            );
            var data = _warehouseRepository.ApprovedGoodsReceivedNote(
                request.debtIds,
                request.status,
                userId
            );
            return Json(data);
        }

        public FileResult DownloadTemplate()
        {
            string path = Path.Combine(
                _environment.WebRootPath,
                "/Template/UploadMarterialSeria.xlsx"
            );
            return File(path, "application/vnd.ms-excel", "UploadMarterialSeria.xlsx");
        }

        [HttpPost]
        public async Task<ActionResult> ReadMaterialSeriaFile(
            IFormFile file,
            bool isDelivery,
            int gdnid,
            int materiaId
        )
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            List<ReadMaterialSeriaCSVModel> dataImport = new();
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

                using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        bool isFirstRow = true; // đánh dấu dòng đầu tiên

                        do
                        {
                            while (reader.Read())
                            {
                                if (isFirstRow) // bỏ qua header
                                {
                                    isFirstRow = false;
                                    continue;
                                }

                                ReadMaterialSeriaCSVModel dataInFileImport =
                                    new ReadMaterialSeriaCSVModel
                                    {
                                        phoneNumber = reader.IsDBNull(0)
                                            ? ""
                                            : reader.GetValue(0).ToString(),
                                        seria = reader.IsDBNull(1)
                                            ? ""
                                            : reader.GetValue(1).ToString(),
                                        position = reader.IsDBNull(2)
                                            ? ""
                                            : reader.GetValue(2).ToString(),
                                    };

                                dataImport.Add(dataInFileImport);
                            }
                        } while (reader.NextResult());
                    }
                }

                System.IO.File.Delete(filePath);
            }
            //Validate data import
            var dataChecking = _warehouseRepository.CheckMaterialSerias(
                dataImport,
                isDelivery,
                gdnid,
                materiaId
            );
            return Json(dataChecking);
        }

        [Route("add-phieu-nhap-kho")]
        [Authorize(Roles = "Tạo phiếu nhập kho")]
        public ActionResult CreateGoodsReceivedNote()
        {
            ViewBag.Suppliers = _accountRepository.GetAgentForCombo();
            ViewBag.Staffs = _accountRepository.GetStaffForCombo();
            ViewBag.Banks = _bankRepository.GetBankForCombo();
            ViewBag.Materials = _warehouseRepository.GetMaterialForCombo();
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
            //ViewBag.DataTable = _warehouseRepository.GetListGoodsReceivedNote();
            GoodsReceivedNoteModel goodsReceivedNoteModel = new GoodsReceivedNoteModel()
            {
                NewDebt = 0,
                OldDebt = 0,
                TotalPrice = 0,
                CongNoPhatSinh = 0,
                TienPhaiTra = 0,
                TienDaTra = 0,
                Warehouses = new(),
            };
            return View(goodsReceivedNoteModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-phieu-nhap-kho")]
        [Authorize(Roles = "Tạo phiếu nhập kho")]
        public ActionResult CreateGoodsReceivedNote(GoodsReceivedNoteModel request)
        {
            try
            {
                ViewBag.Suppliers = _accountRepository.GetAgentForCombo();
                ViewBag.Staffs = _accountRepository.GetStaffForCombo();
                ViewBag.Banks = _bankRepository.GetBankForCombo();
                ViewBag.Materials = _warehouseRepository.GetMaterialForCombo();
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
                if (request.Warehouses == null)
                    request.Warehouses = new();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }
                //Kiểm tra đã nhập seria với nguyên liệu cần nhập seria
                var warehouses = request.Warehouses;
                foreach (var item in warehouses)
                {
                    if (item.UsingSeria)
                    {
                        if (item.materialSerias == null)
                        {
                            ModelState.AddModelError(System.String.Empty, "Bạn chưa import seria.");
                            return View(request);
                        }
                    }
                }

                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _warehouseRepository.CreateGoodsReceivedNote(request, userId ?? "");
                if (result.Code == "1")
                {
                    return RedirectToAction(
                        nameof(EditGoodsReceivedNote),
                        new { id = result.Data }
                    );
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        [Route("xem-phieu-nhap-kho")]
        [Authorize(Roles = "Xem phiếu nhập kho")]
        public ActionResult GoodsReceivedNoteDetail(int id)
        {
            ViewBag.Suppliers = _accountRepository.GetAgentForCombo();
            ViewBag.Staffs = _accountRepository.GetStaffForCombo();
            ViewBag.Banks = _bankRepository.GetBankForCombo();
            ViewBag.Materials = _warehouseRepository.GetMaterialForCombo();
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
            var GoodsReceivedNoteDetail = _warehouseRepository.GetGoodsReceivedNoteDetail(id);
            return View(GoodsReceivedNoteDetail);
        }

        [Route("edit-phieu-nhap-kho")]
        [Authorize(Roles = "Sửa phiếu nhập kho")]
        public ActionResult EditGoodsReceivedNote(int id)
        {
            ViewBag.Suppliers = _accountRepository.GetAgentForCombo();
            ViewBag.Staffs = _accountRepository.GetStaffForCombo();
            ViewBag.Banks = _bankRepository.GetBankForCombo();
            ViewBag.Materials = _warehouseRepository.GetMaterialForCombo();
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
            var GoodsReceivedNoteDetail = _warehouseRepository.GetGoodsReceivedNoteDetail(id);
            return View(GoodsReceivedNoteDetail);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-phieu-nhap-kho")]
        [Authorize(Roles = "Sửa phiếu nhập kho")]
        public ActionResult EditGoodsReceivedNote(GoodsReceivedNoteModel request)
        {
            try
            {
                ViewBag.Suppliers = _accountRepository.GetAgentForCombo();
                ViewBag.Staffs = _accountRepository.GetStaffForCombo();
                ViewBag.Banks = _bankRepository.GetBankForCombo();
                ViewBag.Materials = _warehouseRepository.GetMaterialForCombo();
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
                if (!ModelState.IsValid)
                {
                    return View(request);
                }
                //Kiểm tra đã nhập seria với nguyên liệu cần nhập seria
                var warehouses = request.Warehouses;
                foreach (var item in warehouses)
                {
                    if (item.UsingSeria)
                    {
                        if (item.materialSerias == null)
                        {
                            ModelState.AddModelError(System.String.Empty, "Bạn chưa import seria.");
                            return View(request);
                        }
                    }
                }
                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _warehouseRepository.UpdateGoodsReceivedNote(request, userId ?? "");
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(EditGoodsReceivedNote), new { id = request.Id });
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        [Authorize(Roles = "Xóa phiếu nhập kho")]
        public ActionResult DeleteGoodsReceivedNote(int id)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                ClaimTypes.NameIdentifier
            );
            var result = _warehouseRepository.DeleteGoodsReceivedNote(id, userId ?? "");
            return Json(result);
        }
        #endregion

        #region GoodsDeliveryNote

        [Route("phieu-xuat-kho")]
        [Authorize(Roles = "Xem phiếu xuất kho")]
        public ActionResult GoodsDeliveryNoteList()
        {
            ViewBag.Agents = _accountRepository.GetAgentForCombo();
            ViewBag.Staffs = _accountRepository.GetStaffForCombo();
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

        public ActionResult SearchGoodsDeliveryNote(
            [FromBody] GoodsDeliveryNoteFilterRequest request
        )
        {
            //request.userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = _warehouseRepository.GetListGoodsDeliveryNote(request);
            return Json(data);
        }

        public ActionResult ApprovedGoodsDeliveryNote([FromBody] ApprovedDebtRequest request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                ClaimTypes.NameIdentifier
            );
            var data = _warehouseRepository.ApprovedGoodsDeliveryNote(
                request.debtIds,
                request.status,
                userId
            );
            return Json(data);
        }

        [Route("add-phieu-xuat-kho")]
        [Authorize(Roles = "Tạo phiếu xuất kho")]
        public ActionResult CreateGoodsDeliveryNote()
        {
            ViewBag.Suppliers = _accountRepository.GetAgentForCombo();
            ViewBag.Staffs = _accountRepository.GetStaffForCombo();
            ViewBag.Banks = _bankRepository.GetBankForCombo();
            ViewBag.Materials = _warehouseRepository.GetMaterialForCombo();
            ViewBag.DeliveryAgents = _accountRepository.GetAgentForCombo();
            ViewBag.FormOfDelivery = _simOrderRepository.GetFormOfDeliveryForComb();
            ViewBag.Banks = _bankRepository.GetBankForCombo();
            ViewBag.ShippingUnits = _shippingUnitRepository.GetShippingUnitForCombo();
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
            ViewBag.PayOrderType = payOrderSelectedItems;
            //ViewBag.DataTable = _warehouseRepository.GetListGoodsDeliveryNote();
            GoodsDeliveryNoteModel GoodsDeliveryNoteModel = new GoodsDeliveryNoteModel()
            {
                NewDebt = 0,
                OldDebt = 0,
                TotalPrice = 0,
                TienDaThu = 0,
                PhaiThuConLai = 0,
                Warehouses = new(),
            };
            return View(GoodsDeliveryNoteModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-phieu-xuat-kho")]
        [Authorize(Roles = "Tạo phiếu xuất kho")]
        public ActionResult CreateGoodsDeliveryNote(GoodsDeliveryNoteModel request)
        {
            try
            {
                ViewBag.Suppliers = _accountRepository.GetAgentForCombo();
                ViewBag.Staffs = _accountRepository.GetStaffForCombo();
                ViewBag.Banks = _bankRepository.GetBankForCombo();
                ViewBag.Materials = _warehouseRepository.GetMaterialForCombo();
                ViewBag.DeliveryAgents = _accountRepository.GetAgentForCombo();
                ViewBag.FormOfDelivery = _simOrderRepository.GetFormOfDeliveryForComb();
                ViewBag.Banks = _bankRepository.GetBankForCombo();
                ViewBag.ShippingUnits = _shippingUnitRepository.GetShippingUnitForCombo();
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
                ViewBag.PayOrderType = payOrderSelectedItems;
                if (request.Warehouses == null)
                    request.Warehouses = new();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _warehouseRepository.CreateGoodsDeliveryNote(request, userId ?? "");
                if (result.Code == "1")
                {
                    return RedirectToAction(
                        nameof(EditGoodsDeliveryNote),
                        new { id = result.Data }
                    );
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        [Route("xem-phieu-xuat-kho")]
        [Authorize(Roles = "Xem phiếu xuất kho")]
        public ActionResult GoodsDeliveryNoteDetail(int id)
        {
            ViewBag.Suppliers = _accountRepository.GetAgentForCombo();
            ViewBag.Staffs = _accountRepository.GetStaffForCombo();
            ViewBag.Banks = _bankRepository.GetBankForCombo();
            ViewBag.Materials = _warehouseRepository.GetMaterialForCombo();
            ViewBag.FormOfDelivery = _simOrderRepository.GetFormOfDeliveryForComb();
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
            var GoodsDeliveryNoteDetail = _warehouseRepository.GetGoodsDeliveryNoteDetail(id);
            return View(GoodsDeliveryNoteDetail);
        }

        [Route("edit-phieu-xuat-kho")]
        [Authorize(Roles = "Sửa phiếu xuất kho")]
        public ActionResult EditGoodsDeliveryNote(int id)
        {
            ViewBag.Suppliers = _accountRepository.GetAgentForCombo();
            ViewBag.Staffs = _accountRepository.GetStaffForCombo();
            ViewBag.Banks = _bankRepository.GetBankForCombo();
            ViewBag.Materials = _warehouseRepository.GetMaterialForCombo();
            ViewBag.FormOfDelivery = _simOrderRepository.GetFormOfDeliveryForComb();
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
            var GoodsDeliveryNoteDetail = _warehouseRepository.GetGoodsDeliveryNoteDetail(id);
            return View(GoodsDeliveryNoteDetail);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-phieu-xuat-kho")]
        [Authorize(Roles = "Sửa phiếu xuất kho")]
        public ActionResult EditGoodsDeliveryNote(GoodsDeliveryNoteModel request)
        {
            try
            {
                ViewBag.Suppliers = _accountRepository.GetAgentForCombo();
                ViewBag.Staffs = _accountRepository.GetStaffForCombo();
                ViewBag.Banks = _bankRepository.GetBankForCombo();
                ViewBag.Materials = _warehouseRepository.GetMaterialForCombo();
                ViewBag.FormOfDelivery = _simOrderRepository.GetFormOfDeliveryForComb();
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
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );
                var result = _warehouseRepository.UpdateGoodsDeliveryNote(request, userId ?? "");
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(EditGoodsDeliveryNote), new { id = request.Id });
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        [Authorize(Roles = "Xóa phiếu xuất kho")]
        public ActionResult DeleteGoodsDeliveryNote(int id)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(
                ClaimTypes.NameIdentifier
            );
            var result = _warehouseRepository.DeleteGoodsDeliveryNote(id, userId ?? "");
            return Json(result);
        }
        #endregion

        #region Other

        #endregion
    }
}
