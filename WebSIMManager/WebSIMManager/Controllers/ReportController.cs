using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;
using Repositories.Implement;
using Repositories.Interface;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;

namespace WebSIMManager.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        private readonly ISIMRepository _simRepository;
        private readonly ISIMOrderRepository _orderRepository;
        private readonly IDebtRepository _debtRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _environment;
        private readonly ILogActionRepository _logAction;
        private readonly IWarehouseRepository _warehouseRepository;
        public ReportController(ISIMRepository simRepository, IHttpContextAccessor httpContextAccessor, ISIMOrderRepository orderRepository, IDebtRepository debtRepository, IWebHostEnvironment environment, IAccountRepository accountRepository, ILogActionRepository logAction, IWarehouseRepository warehouseRepository)
        {
            _simRepository = simRepository;
            _orderRepository = orderRepository;
            _debtRepository = debtRepository;
            _httpContextAccessor = httpContextAccessor;
            _environment = environment;
            _accountRepository = accountRepository;
            _logAction = logAction;
            _warehouseRepository = warehouseRepository;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DebtAgents()
        {
            return View();
        }
        public ActionResult DebtCustomers()
        {
            return View();
        }
        [Route("ton-kho")]
        public ActionResult Inventory()
        {
            var agents = _accountRepository.GetAgentForCombo();
            agents[0].Selected = true;
            @ViewBag.Agents = agents;
            return View();
        }

        public ActionResult SearchInventory([FromBody] ReportFilterModels request)
        {
            var data = _simRepository.GetInventoryReport(request);
            return Json(data);
        }

        // GET: ReportController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReportController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReportController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReportController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReportController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReportController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        #region Nhóm đại lý
        [Route("nhom-dai-ly")]
        public ActionResult AgencyGroup()
        {
            var agents = _accountRepository.GetAgentForCombo();
            @ViewBag.Agents = agents;
            return View();
        }

        public ActionResult SearchAgencyGroup([FromBody] AgencyGroupReportRequest request)
        {
            var data = _debtRepository.GetAgencyGroupReport(request);
            return Json(data);
        }

        public ActionResult ExportAgencyGroup([FromBody] AgencyGroupReportRequest request)
        {
            request.isPaged = false;
            var data = _debtRepository.GetAgencyGroupReport(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "";
            worksheet.Cell(1, 2).Value = "Thông tin Đại Lý";
            worksheet.Cell(1, 5).Value = "Công Nợ Cuối kỳ";
            worksheet.Cell(2, 5).Value = data.Data.Sum(t => t.TotalReceivables) - data.Data.Sum(t => t.TotalLiabilities);
            worksheet.Cell(2, 5).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(3, 1).Value = "STT";
            worksheet.Cell(3, 2).Value = "Tên đại lý";
            worksheet.Cell(3, 3).Value = "Điện thoại";
            worksheet.Cell(3, 4).Value = "Địa chỉ";
            worksheet.Cell(3, 5).Value = "Phải thu";
            worksheet.Cell(3, 6).Value = "Phải trả";
            worksheet.Cell(3, 7).Value = "Nợ cuối";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 4, 1).Value = data.Data[i].Stt;
                worksheet.Cell(i + 4, 2).Value = data.Data[i].FullName;
                worksheet.Cell(i + 4, 3).Value = data.Data[i].PhoneNumber;
                worksheet.Cell(i + 4, 4).Value = data.Data[i].Address;
                worksheet.Cell(i + 4, 5).Value = data.Data[i].TotalReceivables;
                worksheet.Cell(i + 4, 5).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 4, 6).Value = data.Data[i].TotalLiabilities;
                worksheet.Cell(i + 4, 6).Style.NumberFormat.Format = "#,##0";
            }
            worksheet.Cell(data.Data.Count + 4, 2).Value = "Tổng:";
            worksheet.Cell(data.Data.Count + 4, 5).Value = data.Data.Sum(t => t.TotalReceivables ?? 0);
            worksheet.Cell(data.Data.Count + 4, 5).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(data.Data.Count + 4, 6).Value = data.Data.Sum(t => t.TotalLiabilities ?? 0);
            worksheet.Cell(data.Data.Count + 4, 6).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(data.Data.Count + 4, 7).Value = data.Data.Sum(t => t.TotalFinalDebt ?? 0);
            worksheet.Cell(data.Data.Count + 4, 7).Style.NumberFormat.Format = "#,##0";

            var title1 = worksheet.Range("A1:A2");
            title1.Merge();
            var title2 = worksheet.Range("B1:D2");
            title2.Merge();
            var title3 = worksheet.Range("E1:F1");
            title3.Merge();
            var title4 = worksheet.Range("E2:F2");
            title4.Merge();

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion

        #region Kho số công ty
        [Route("kho-so-cong-ty")]
        public ActionResult SimInventoryCompany()
        {
            @ViewBag.ProductTypes = _simRepository.GetProductTypeForCombo();
            @ViewBag.Owners = _accountRepository.GetAgentForCombo();
            @ViewBag.Networks = _simRepository.GetSIMNetworkListForCombo();
            return View();
        }

        public ActionResult SearchSimInventoryCompany([FromBody] SimInventoryCompanyReportRequest request)
        {
            var data = _simRepository.GetSimInventoryCompany(request);
            return Json(data);
        }

        public ActionResult ExportSimInventoryCompany([FromBody] SimInventoryCompanyReportRequest request)
        {
            request.isPaged = false;
            var data = _simRepository.GetSimInventoryCompany(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Đã Đặt";
            worksheet.Cell(1, 2).Value = "Số sim";
            worksheet.Cell(1, 3).Value = "Seri sim";
            worksheet.Cell(1, 4).Value = "Sim số đẹp";
            worksheet.Cell(1, 5).Value = "Loại sim";
            worksheet.Cell(1, 6).Value = "Nhà mạng";
            worksheet.Cell(1, 7).Value = "Đơn giá nhập";
            worksheet.Cell(1, 8).Value = "Đơn giá bán lẻ";
            worksheet.Cell(1, 9).Value = "Chủ sở hữu";
            worksheet.Cell(1, 10).Value = "Số liên hệ";
            worksheet.Cell(1, 11).Value = "Vị trí";
            worksheet.Cell(1, 12).Value = "Ghi chú \\ Diễn giải";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = data.Data[i].IsBooked;
                worksheet.Cell(i + 2, 2).Value = data.Data[i].SIMNumber;
                worksheet.Cell(i + 2, 3).Value = data.Data[i].SIMSeriaNumber;
                worksheet.Cell(i + 2, 4).Value = data.Data[i].SIMType;
                worksheet.Cell(i + 2, 5).Value = data.Data[i].ProductType;
                worksheet.Cell(i + 2, 6).Value = data.Data[i].Network;
                worksheet.Cell(i + 2, 7).Value = data.Data[i].SIMPriceOfAgent;
                worksheet.Cell(i + 2, 7).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 8).Value = data.Data[i].SIMPrice;
                worksheet.Cell(i + 2, 8).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 9).Value = data.Data[i].OwnerName;
                worksheet.Cell(i + 2, 10).Value = data.Data[i].OwnerPhoneNumber;
                worksheet.Cell(i + 2, 11).Value = data.Data[i].Position;
                worksheet.Cell(i + 2, 12).Value = data.Data[i].Description;
            }

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion

        #region Xuất hàng hoá
        [Route("xuat-hang-hoa")]
        public ActionResult WarehouseOutbound()
        {
            ViewBag.Materials = _warehouseRepository.GetMaterialForCombo();
            return View();
        }

        public ActionResult SearchWarehouseOutbound([FromBody] WarehouseOutboundReportRequest request)
        {
            var data = _simRepository.GetWarehouseOutbound(request);
            return Json(data);
        }

        public ActionResult ExportWarehouseOutbound([FromBody] WarehouseOutboundReportRequest request)
        {
            request.isPaged = false;
            var data = _simRepository.GetWarehouseOutbound(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Mã";
            worksheet.Cell(1, 2).Value = "Tên";
            worksheet.Cell(1, 3).Value = "SL xuất";
            worksheet.Cell(1, 4).Value = "Đ/G gốc";
            worksheet.Cell(1, 5).Value = "Đ/G bán";
            worksheet.Cell(1, 6).Value = "Thành tiền bán";
            worksheet.Cell(1, 7).Value = "Ngày xuất";
            worksheet.Cell(1, 8).Value = "Khách hàng";
            worksheet.Cell(1, 9).Value = "Kho";
            worksheet.Cell(1, 10).Value = "Ghi chú";

            var groupedProducts = data.Data.GroupBy(t => t.ProductTypeId);

            int currentRow = 2;

            // Iterate through each group
            foreach (var group in groupedProducts)
            {
                // Group label
                worksheet.Cell(currentRow, 1).Value = $"Loại sản phẩm: {group.Key}-{group.FirstOrDefault()?.ProductType}";
                worksheet.Cell(currentRow, 1).Style.Font.Bold = true;
                currentRow++;

                // Iterate through products in the group
                foreach (var product in group)
                {
                    worksheet.Cell(currentRow, 1).Value = product.Code;
                    worksheet.Cell(currentRow, 2).Value = product.Name;
                    worksheet.Cell(currentRow, 3).Value = product.Quantity;
                    worksheet.Cell(currentRow, 3).Style.NumberFormat.Format = "#,##0";
                    worksheet.Cell(currentRow, 4).Value = product.OriginalPrice;
                    worksheet.Cell(currentRow, 4).Style.NumberFormat.Format = "#,##0";
                    worksheet.Cell(currentRow, 5).Value = product.SellingPrice;
                    worksheet.Cell(currentRow, 5).Style.NumberFormat.Format = "#,##0";
                    worksheet.Cell(currentRow, 6).Value = product.TotalSellingAmount;
                    worksheet.Cell(currentRow, 6).Style.NumberFormat.Format = "#,##0";
                    worksheet.Cell(currentRow, 7).Value = product.ExportDate?.ToString("dd/MM/yyyy HH:mm:ss");
                    worksheet.Cell(currentRow, 8).Value = product.Customer;
                    worksheet.Cell(currentRow, 9).Value = product.Warehouse;
                    worksheet.Cell(currentRow, 10).Value = product.Note;
                    currentRow++;
                }

                // Group the rows
                worksheet.Rows(currentRow - group.Count(), currentRow - 1).Group();
                //currentRow++;
            }

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion

        #region Sim đã bán

        [Route("sim-da-ban")]
        public ActionResult SoldSim()
        {
            return View();
        }

        public ActionResult SearchSoldSim([FromBody] SoldSimReportRequest request)
        {
            var data = _simRepository.GetSoldSim(request);
            return Json(data);
        }
        public ActionResult ExportSoldSim([FromBody] SoldSimReportRequest request)
        {
            request.isPaged = false;
            var data = _simRepository.GetSoldSim(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Thông phiếu xuất";
            worksheet.Cell(1, 8).Value = "Thông tin bên mua";
            worksheet.Cell(1, 13).Value = "Thông tin bên GD hộ/ĐV Vận chuyển";
            worksheet.Cell(1, 16).Value = "Thông tin khác";

            worksheet.Cell(2, 1).Value = "Ngày xuất";
            worksheet.Cell(2, 2).Value = "Mã phiếu";
            worksheet.Cell(2, 3).Value = "Số sim";
            worksheet.Cell(2, 4).Value = "Tổng đơn hàng";
            worksheet.Cell(2, 5).Value = "Tổng đã TT";
            worksheet.Cell(2, 6).Value = "Còn lại chưa TT";
            worksheet.Cell(2, 7).Value = "Ghi chú";
            worksheet.Cell(2, 8).Value = "Mã khách hàng";
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

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 3, 1).Value = data.Data[i].CreateTime.ToString("dd/MM/yyyy HH:mm:ss");
                worksheet.Cell(i + 3, 2).Value = data.Data[i].Code;
                worksheet.Cell(i + 3, 3).Value = data.Data[i].SimNumbers;
                worksheet.Cell(i + 3, 4).Value = data.Data[i].TotalOrders;
                worksheet.Cell(i + 3, 4).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 5).Value = data.Data[i].TotalPaid;
                worksheet.Cell(i + 3, 5).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 6).Value = data.Data[i].RemainingUnpaid;
                worksheet.Cell(i + 3, 6).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 7).Value = data.Data[i].Note;
                worksheet.Cell(i + 3, 8).Value = data.Data[i].CustomerCode;
                worksheet.Cell(i + 3, 9).Value = data.Data[i].CustomerName;
                worksheet.Cell(i + 3, 10).Value = data.Data[i].CustomerPhone;
                worksheet.Cell(i + 3, 11).Value = data.Data[i].CustomerAddress;
                worksheet.Cell(i + 3, 12).Value = data.Data[i].BuyerDeductionFee;
                worksheet.Cell(i + 3, 12).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 13).Value = data.Data[i].ShippingName?.ToString();
                worksheet.Cell(i + 3, 14).Value = data.Data[i].COD;
                worksheet.Cell(i + 3, 14).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 15).Value = data.Data[i].ShippingFee;
                worksheet.Cell(i + 3, 15).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 16).Value = data.Data[i].FormOfDelivery;
                worksheet.Cell(i + 3, 17).Value = data.Data[i].Seller;
                worksheet.Cell(i + 3, 18).Value = data.Data[i].Creator;
                worksheet.Cell(i + 3, 19).Value = data.Data[i].FlagCOD;
                worksheet.Cell(i + 3, 20).Value = data.Data[i].FlagThuHo;
            }

            var title1 = worksheet.Range("A1:G1");
            title1.Merge();
            var title2 = worksheet.Range("H1:L1");
            title2.Merge();
            var title3 = worksheet.Range("M1:O1");
            title3.Merge();
            var title4 = worksheet.Range("P1:T1");
            title4.Merge();

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion

        #region Tình hình lợi nhuận
        [Route("tinh-hinh-loi-nhuan")]
        public ActionResult ProfitSituation()
        {
            return View();
        }
        public ActionResult SearchProfitSituation([FromBody] ProfitSituationReportRequest request)
        {
            var data = _simRepository.GetProfitSituation(request);
            return Json(data);
        }
        public ActionResult ExportProfitSituation([FromBody] ProfitSituationReportRequest request)
        {
            request.isPaged = false;
            var data = _simRepository.GetProfitSituation(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Mã hàng";
            worksheet.Cell(1, 2).Value = "Tên hàng";
            worksheet.Cell(1, 3).Value = "ĐVT";
            worksheet.Cell(1, 4).Value = "Nhóm hàng";
            worksheet.Cell(1, 5).Value = "SL";
            worksheet.Cell(1, 6).Value = "ĐG nhập";
            worksheet.Cell(1, 7).Value = "Tổng tiền nhập";
            worksheet.Cell(1, 8).Value = "ĐG bán";
            worksheet.Cell(1, 9).Value = "Tổng tiền bán";
            worksheet.Cell(1, 10).Value = "Lợi nhuận";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = data.Data[i].ProductCode;
                worksheet.Cell(i + 2, 2).Value = data.Data[i].ProductName;
                worksheet.Cell(i + 2, 3).Value = data.Data[i].Unit;
                worksheet.Cell(i + 2, 4).Value = data.Data[i].ProductGroup;
                worksheet.Cell(i + 2, 5).Value = data.Data[i].Quantity;
                worksheet.Cell(i + 2, 5).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 6).Value = data.Data[i].UnitPriceOnPurchase;
                worksheet.Cell(i + 2, 6).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 7).Value = data.Data[i].TotalPurchaseAmount;
                worksheet.Cell(i + 2, 7).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 8).Value = data.Data[i].UnitPriceOnSale;
                worksheet.Cell(i + 2, 8).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 9).Value = data.Data[i].TotalSalesAmount;
                worksheet.Cell(i + 2, 9).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 10).Value = data.Data[i].Profit;
                worksheet.Cell(i + 2, 10).Style.NumberFormat.Format = "#,##0";
            }

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion

        #region Tiền tồn trong quỹ
        [Route("tien-ton-trong-quy")]
        public ActionResult CashFundBalance()
        {
            return View();
        }
        public ActionResult SearchCashFundBalance([FromBody] CashFundBalanceReportRequest request)
        {
            var data = _simRepository.GetCashFundBalance(request);
            return Json(data);
        }
        public ActionResult ExportCashFundBalance([FromBody] CashFundBalanceReportRequest request)
        {
            request.isPaged = false;
            var data = _simRepository.GetCashFundBalance(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Quỹ";
            worksheet.Cell(1, 2).Value = "Tổng tiền";
            worksheet.Cell(1, 3).Value = "Số dư hiện tại";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = data.Data[i].StaffName;
                worksheet.Cell(i + 2, 2).Value = data.Data[i].TotalBalance;
                worksheet.Cell(i + 2, 2).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 3).Value = data.Data[i].CurrentBalance;
                worksheet.Cell(i + 2, 3).Style.NumberFormat.Format = "#,##0";
            }

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion

        #region Tiền tồn trong ngân hàng
        [Route("tien-ton-trong-ngan-hang")]
        public ActionResult BankBalance()
        {
            return View();
        }
        public ActionResult SearchBankBalance([FromBody] BankBalanceReportRequest request)
        {
            var data = _simRepository.GetBankBalance(request);
            return Json(data);
        }
        public ActionResult ExportBankBalance([FromBody] BankBalanceReportRequest request)
        {
            request.isPaged = false;
            var data = _simRepository.GetBankBalance(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Tên tài khoản";
            worksheet.Cell(1, 2).Value = "Số tài khoản";
            worksheet.Cell(1, 3).Value = "Tổng tiền đã duyệt";
            worksheet.Cell(1, 4).Value = "Tổng tiền chưa duyệt";

            var groupedProducts = data.Data.GroupBy(t => t.Id);

            int currentRow = 2;

            // Iterate through each group
            foreach (var group in groupedProducts)
            {
                // Group label
                worksheet.Cell(currentRow, 1).Value = $"Ngân hàng: {group.FirstOrDefault()?.BankName}";
                worksheet.Cell(currentRow, 1).Style.Font.Bold = true;
                currentRow++;

                // Iterate through products in the group
                foreach (var product in group)
                {
                    worksheet.Cell(currentRow, 1).Value = product.AccountName;
                    worksheet.Cell(currentRow, 2).Value = product.AccountNumber;
                    worksheet.Cell(currentRow, 3).Value = product.ApprovedTotalAmount;
                    worksheet.Cell(currentRow, 3).Style.NumberFormat.Format = "#,##0";
                    worksheet.Cell(currentRow, 4).Value = product.WaitingApprovedTotalAmount;
                    worksheet.Cell(currentRow, 4).Style.NumberFormat.Format = "#,##0";
                    currentRow++;
                }

                // Group the rows
                worksheet.Rows(currentRow - group.Count(), currentRow - 1).Group();
                //currentRow++;
            }

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion

        #region Lợi nhuận số đẹp
        [Route("loi-nhuan-so-dep")]
        public ActionResult ProfitStatement()
        {
            return View();
        }
        public ActionResult SearchProfitStatemente([FromBody] ProfitStatementReportRequest request)
        {
            var data = _simRepository.GetProfitStatement(request);
            return Json(data);
        }
        public ActionResult ExportProfitStatemente([FromBody] ProfitStatementReportRequest request)
        {
            request.isPaged = false;
            var data = _simRepository.GetProfitStatement(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Thông tin phiếu";
            worksheet.Cell(1, 6).Value = $"Thông tin sim ({data.Data.Count} sim)";
            worksheet.Cell(1, 12).Value = "Lãi";
            worksheet.Cell(1, 13).Value = "Tổng";
            worksheet.Cell(1, 14).Value = "Lãi";
            worksheet.Cell(1, 15).Value = "Nhân viên thực hiện";

            worksheet.Cell(2, 1).Value = "Thông tin phiếu";
            worksheet.Cell(2, 2).Value = "Mã phiếu";
            worksheet.Cell(2, 3).Value = "Mã KH";
            worksheet.Cell(2, 4).Value = "Tên KH";
            worksheet.Cell(2, 5).Value = "Kênh bán";
            worksheet.Cell(2, 6).Value = "Sim nhà";
            worksheet.Cell(2, 7).Value = "Số sim";
            worksheet.Cell(2, 8).Value = "Vị trí";
            worksheet.Cell(2, 9).Value = "Đại lý có sim";
            worksheet.Cell(2, 10).Value = "Tiền nhập";
            worksheet.Cell(2, 11).Value = "Tiền bán";
            worksheet.Cell(2, 12).Value = "Chưa trừ phí";
            worksheet.Cell(2, 13).Value = "Các chi phí";
            worksheet.Cell(2, 14).Value = "Đã trừ phí";
            worksheet.Cell(2, 15).Value = "Người bán";
            worksheet.Cell(2, 16).Value = "Người lập";
            worksheet.Cell(2, 17).Value = "Người ghi nhận";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 3, 1).Value = data.Data[i].ExportDate.ToString("dd/MM/yyyy HH:mm:ss");
                worksheet.Cell(i + 3, 2).Value = data.Data[i].InvoiceCode;
                worksheet.Cell(i + 3, 3).Value = data.Data[i].CustomerCode;
                worksheet.Cell(i + 3, 4).Value = data.Data[i].CustomerName;
                worksheet.Cell(i + 3, 5).Value = data.Data[i].SalesChannel;
                worksheet.Cell(i + 3, 6).Value = data.Data[i].HomeSIM.ToString();
                worksheet.Cell(i + 3, 7).Value = data.Data[i].NumberOfSIMs;
                worksheet.Cell(i + 3, 8).Value = data.Data[i].Location;
                worksheet.Cell(i + 3, 9).Value = data.Data[i].Agency;
                worksheet.Cell(i + 3, 10).Value = data.Data[i].PurchaseAmount;
                worksheet.Cell(i + 3, 10).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 11).Value = data.Data[i].SellingAmount;
                worksheet.Cell(i + 3, 11).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 12).Value = data.Data[i].NotDeductedFee;
                worksheet.Cell(i + 3, 12).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 13).Value = data.Data[i].Expenses;
                worksheet.Cell(i + 3, 13).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 14).Value = data.Data[i].DeductedFee;
                worksheet.Cell(i + 3, 14).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 15).Value = data.Data[i].Seller;
                worksheet.Cell(i + 3, 16).Value = data.Data[i].Creator;
                worksheet.Cell(i + 3, 17).Value = data.Data[i].Recorder;
            }

            worksheet.Cell(data.Data.Count + 3, 2).Value = data.Data.Count.ToString();
            worksheet.Cell(data.Data.Count + 3, 10).Value = data.Data.Sum(t => t.PurchaseAmount);
            worksheet.Cell(data.Data.Count + 3, 10).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(data.Data.Count + 3, 11).Value = data.Data.Sum(t => t.SellingAmount);
            worksheet.Cell(data.Data.Count + 3, 11).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(data.Data.Count + 3, 12).Value = data.Data.Sum(t => t.NotDeductedFee);
            worksheet.Cell(data.Data.Count + 3, 12).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(data.Data.Count + 3, 13).Value = data.Data.Sum(t => t.Expenses);
            worksheet.Cell(data.Data.Count + 3, 13).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(data.Data.Count + 3, 14).Value = data.Data.Sum(t => t.DeductedFee);
            worksheet.Cell(data.Data.Count + 3, 14).Style.NumberFormat.Format = "#,##0";
            var rowSum = worksheet.Range($"A{data.Data.Count + 3}:Q{data.Data.Count + 3}");
            rowSum.Style.Font.Bold = true;

            var title1 = worksheet.Range("A1:E1");
            title1.Merge();
            var title2 = worksheet.Range("F1:K1");
            title2.Merge();
            var title3 = worksheet.Range("O1:Q1");
            title3.Merge();

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion

        #region Lợi nhuận theo đơn hàng
        [Route("loi-nhuan-theo-don-hang")]
        public ActionResult OrderProfit()
        {
            return View();
        }
        public ActionResult SearchOrderProfit([FromBody] OrderProfitReportRequest request)
        {
            var data = _simRepository.GetOrderProfit(request);
            return Json(data);
        }
        public ActionResult ExportOrderProfit([FromBody] OrderProfitReportRequest request)
        {
            request.isPaged = false;
            var data = _simRepository.GetOrderProfit(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            worksheet.Cell(1, 1).Value = "Thông tin phiếu";
            worksheet.Cell(1, 4).Value = $"Thông tin sim ({data.Data.Count} sim)";
            worksheet.Cell(1, 8).Value = "Lãi";
            worksheet.Cell(1, 9).Value = "Tổng";
            worksheet.Cell(1, 10).Value = "Lãi";
            worksheet.Cell(1, 11).Value = "Nhân viên thực hiện";

            var title1 = worksheet.Range("A1:C1");
            title1.Merge();
            var title2 = worksheet.Range("D1:G1");
            title2.Merge();

            worksheet.Cell(2, 1).Value = "Ngày xuất";
            worksheet.Cell(2, 2).Value = "Mã phiếu";
            worksheet.Cell(2, 3).Value = "Tên KH";
            worksheet.Cell(2, 4).Value = "Số sim";
            worksheet.Cell(2, 5).Value = "Đại lý có sim";
            worksheet.Cell(2, 6).Value = "Tiền nhập";
            worksheet.Cell(2, 7).Value = "Tiền bán";
            worksheet.Cell(2, 8).Value = "Chưa trừ phí";
            worksheet.Cell(2, 9).Value = "Các chi phí";
            worksheet.Cell(2, 10).Value = "Đã trừ phí";
            worksheet.Cell(2, 11).Value = "Người lập";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 3, 1).Value = data.Data[i].ExportDate.ToString("dd/MM/yyyy HH:mm:ss");
                worksheet.Cell(i + 3, 2).Value = data.Data[i].InvoiceCode;
                worksheet.Cell(i + 3, 3).Value = data.Data[i].CustomerName;
                worksheet.Cell(i + 3, 4).Value = data.Data[i].SIMNumbers;
                worksheet.Cell(i + 3, 5).Value = data.Data[i].Warehouse;
                worksheet.Cell(i + 3, 6).Value = data.Data[i].ImportValue;
                worksheet.Cell(i + 3, 6).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 7).Value = data.Data[i].ExportValue;
                worksheet.Cell(i + 3, 7).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 8).Value = data.Data[i].Interest;
                worksheet.Cell(i + 3, 8).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 9).Value = data.Data[i].Cost;
                worksheet.Cell(i + 3, 9).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 10).Value = data.Data[i].Difference;
                worksheet.Cell(i + 3, 10).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 3, 11).Value = data.Data[i].Creator;
            }

            worksheet.Cell(data.Data.Count + 3, 2).Value = data.Data.Count.ToString();
            worksheet.Cell(data.Data.Count + 3, 6).Value = data.Data.Sum(t => t.ImportValue);
            worksheet.Cell(data.Data.Count + 3, 6).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(data.Data.Count + 3, 7).Value = data.Data.Sum(t => t.ExportValue);
            worksheet.Cell(data.Data.Count + 3, 7).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(data.Data.Count + 3, 8).Value = data.Data.Sum(t => t.Interest);
            worksheet.Cell(data.Data.Count + 3, 8).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(data.Data.Count + 3, 9).Value = data.Data.Sum(t => t.Cost);
            worksheet.Cell(data.Data.Count + 3, 9).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(data.Data.Count + 3, 10).Value = data.Data.Sum(t => t.Difference);
            worksheet.Cell(data.Data.Count + 3, 11).Style.NumberFormat.Format = "#,##0";
            var rowSum = worksheet.Range($"A{data.Data.Count + 3}:K{data.Data.Count + 3}");
            rowSum.Style.Font.Bold = true;

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion

        #region Giao dịch ngân hàng
        [Route("giao-dich-ngan-hang")]
        public ActionResult BankTransaction()
        {
            return View();
        }
        public ActionResult SearchBankTransaction([FromBody] BankTransactionReportRequest request)
        {
            var data = _simRepository.GetBankTransaction(request);
            return Json(data);
        }
        public ActionResult ExportBankTransaction([FromBody] BankTransactionReportRequest request)
        {
            request.isPaged = false;
            var data = _simRepository.GetBankTransaction(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Ngày phát sinh";
            worksheet.Cell(1, 2).Value = "Mã phiếu";
            worksheet.Cell(1, 3).Value = "Tên khách hàng";
            worksheet.Cell(1, 4).Value = "PS Tăng";
            worksheet.Cell(1, 5).Value = "PS Giảm";
            worksheet.Cell(1, 6).Value = "Diễn giải";
            worksheet.Cell(1, 7).Value = "Ghi chú";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = data.Data[i].TransactionDate.ToString("dd/MM/yyyy HH:mm:ss");
                worksheet.Cell(i + 2, 2).Value = data.Data[i].InvoiceCode;
                worksheet.Cell(i + 2, 3).Value = data.Data[i].CustomerName;
                worksheet.Cell(i + 2, 4).Value = data.Data[i].Increase;
                worksheet.Cell(i + 2, 4).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 5).Value = data.Data[i].Decrease;
                worksheet.Cell(i + 2, 5).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 6).Value = data.Data[i].Explanation;
                worksheet.Cell(i + 2, 7).Value = data.Data[i].Note;
            }

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion

        #region Quỹ tiền mặt
        [Route("quy-tien-mat")]
        public ActionResult CashFund()
        {
            return View();
        }
        public ActionResult SearchCashFund([FromBody] CashFundReportRequest request)
        {
            var data = _simRepository.GetCashFund(request);
            return Json(data);
        }
        public ActionResult ExportCashFund([FromBody] CashFundReportRequest request)
        {
            request.isPaged = false;
            var data = _simRepository.GetCashFund(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Ngày phát sinh";
            worksheet.Cell(1, 2).Value = "Mã phiếu";
            worksheet.Cell(1, 3).Value = "Tên khách hàng";
            worksheet.Cell(1, 4).Value = "Thu";
            worksheet.Cell(1, 5).Value = "Chi";
            worksheet.Cell(1, 6).Value = "Diễn giải";
            worksheet.Cell(1, 7).Value = "Ghi chú";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = data.Data[i].DateCreated.ToString("dd/MM/yyyy HH:mm:ss");
                worksheet.Cell(i + 2, 2).Value = data.Data[i].InvoiceCode;
                worksheet.Cell(i + 2, 3).Value = data.Data[i].CustomerName;
                worksheet.Cell(i + 2, 4).Value = data.Data[i].Income;
                worksheet.Cell(i + 2, 4).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 5).Value = data.Data[i].Expense;
                worksheet.Cell(i + 2, 5).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 6).Value = data.Data[i].Description;
                worksheet.Cell(i + 2, 7).Value = data.Data[i].Note;
            }
            worksheet.Cell(data.Data.Count + 2, 1).Value = "Tổng phiếu";
            worksheet.Cell(data.Data.Count + 2, 2).Value = data.Data.Count.ToString();
            worksheet.Cell(data.Data.Count + 2, 4).Value = data.Data.Sum(t => t.Income);
            worksheet.Cell(data.Data.Count + 2, 4).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(data.Data.Count + 2, 5).Value = data.Data.Sum(t => t.Expense);
            worksheet.Cell(data.Data.Count + 2, 5).Style.NumberFormat.Format = "#,##0";
            var rowSum = worksheet.Range($"A{data.Data.Count + 2}:G{data.Data.Count + 2}");
            rowSum.Style.Font.Bold = true;

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion

        #region Kho tồn
        [Route("kho-ton")]
        public ActionResult SimInventory()
        {
            ViewBag.Materials = _warehouseRepository.GetMaterialForCombo();
            return View();
        }
        public ActionResult SearchSimInventory([FromBody] SimInventoryReportRequest request)
        {
            var data = _simRepository.GetSimInventory(request);
            return Json(data);
        }
        public ActionResult ExportSimInventory([FromBody] SimInventoryReportRequest request)
        {
            request.isPaged = false;
            var data = _simRepository.GetSimInventory(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Mã SP";
            worksheet.Cell(1, 2).Value = "Tên sản phẩm";
            worksheet.Cell(1, 3).Value = "SL.Tồn ĐK";
            worksheet.Cell(1, 4).Value = "Nhập T. kỳ";
            worksheet.Cell(1, 5).Value = "Xuất T.kỳ";
            worksheet.Cell(1, 6).Value = "SL.Tồn CK";
            worksheet.Cell(1, 7).Value = "SL. kiểm kê";
            worksheet.Cell(1, 8).Value = "Thừa/Thiếu";
            worksheet.Cell(1, 9).Value = "Ghi chú";

            var groupedProducts = data.Data.GroupBy(t => t.ProductType);

            int currentRow = 2;

            // Iterate through each group
            foreach (var group in groupedProducts)
            {
                // Group label
                worksheet.Cell(currentRow, 1).Value = $"Nhóm sản phẩm: {group.Key}";
                worksheet.Cell(currentRow, 1).Style.Font.Bold = true;
                currentRow++;

                // Iterate through products in the group
                foreach (var product in group)
                {
                    worksheet.Cell(currentRow, 1).Value = product.ProductCode;
                    worksheet.Cell(currentRow, 2).Value = product.ProductName;
                    worksheet.Cell(currentRow, 3).Value = product.OpeningInventory;
                    worksheet.Cell(currentRow, 3).Style.NumberFormat.Format = "#,##0";
                    worksheet.Cell(currentRow, 4).Value = product.TotalPurchases;
                    worksheet.Cell(currentRow, 4).Style.NumberFormat.Format = "#,##0";
                    worksheet.Cell(currentRow, 5).Value = product.TotalSales;
                    worksheet.Cell(currentRow, 5).Style.NumberFormat.Format = "#,##0";
                    worksheet.Cell(currentRow, 6).Value = product.ClosingInventory;
                    worksheet.Cell(currentRow, 6).Style.NumberFormat.Format = "#,##0";
                    worksheet.Cell(currentRow, 7).Value = product.InventoryCount;
                    worksheet.Cell(currentRow, 7).Style.NumberFormat.Format = "#,##0";
                    worksheet.Cell(currentRow, 8).Value = product.SurplusShortage;
                    worksheet.Cell(currentRow, 8).Style.NumberFormat.Format = "#,##0";
                    worksheet.Cell(currentRow, 9).Value = product.Note;
                    currentRow++;
                }

                // Group the rows
                worksheet.Rows(currentRow - group.Count(), currentRow - 1).Group();
                //currentRow++;
            }

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion

        #region Nhập xuất đơn hàng
        [Route("nhap-xuat-don-hang")]
        public ActionResult OrderImportExport()
        {
            return View();
        }
        public ActionResult SearchOrderImportExport([FromBody] OrderImportExportReportRequest request)
        {
            var data = _simRepository.GetOrderImportExport(request);
            return Json(data);
        }
        public ActionResult ExportOrderImportExport([FromBody] OrderImportExportReportRequest request)
        {
            request.isPaged = false;
            var data = _simRepository.GetOrderImportExport(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "STT";
            worksheet.Cell(1, 2).Value = "Ngày phát sinh";
            worksheet.Cell(1, 3).Value = "Mã phiếu";
            worksheet.Cell(1, 4).Value = "Mã";
            worksheet.Cell(1, 5).Value = "Sản phẩm";
            worksheet.Cell(1, 6).Value = "SLượng";
            worksheet.Cell(1, 7).Value = "Khách hàng";
            worksheet.Cell(1, 8).Value = "Loại phiếu";
            worksheet.Cell(1, 9).Value = "Người lập";
            worksheet.Cell(1, 10).Value = "Ngày lập";
            worksheet.Cell(1, 11).Value = "Kho";
            worksheet.Cell(1, 12).Value = "Đã duyệt";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = data.Data[i].Stt;
                worksheet.Cell(i + 2, 2).Value = data.Data[i].DateOfOccurrence.ToString("dd/MM/yyyy HH:mm:ss");
                worksheet.Cell(i + 2, 3).Value = data.Data[i].InvoiceCode;
                worksheet.Cell(i + 2, 4).Value = data.Data[i].Code;
                worksheet.Cell(i + 2, 5).Value = data.Data[i].Product;
                worksheet.Cell(i + 2, 6).Value = data.Data[i].Quantity;
                worksheet.Cell(i + 2, 6).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 7).Value = data.Data[i].Customer;
                worksheet.Cell(i + 2, 8).Value = data.Data[i].InvoiceType;
                worksheet.Cell(i + 2, 9).Value = data.Data[i].Creator;
                worksheet.Cell(i + 2, 10).Value = data.Data[i].DateCreated.ToString("dd/MM/yyyy HH:mm:ss");
                worksheet.Cell(i + 2, 11).Value = data.Data[i].Warehouse;
                worksheet.Cell(i + 2, 12).Value = data.Data[i].Approved.ToString();
            }

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion

        #region Nhập xuất hàng hoá
        [Route("nhap-kho")]
        public ActionResult InventoryMovement()
        {
            ViewBag.Materials = _warehouseRepository.GetMaterialForCombo();
            return View();
        }
        public ActionResult SearchInventoryMovement([FromBody] InventoryMovementReportRequest request)
        {
            var data = _simRepository.GetInventoryMovement(request);
            return Json(data);
        }
        public ActionResult ExportInventoryMovement([FromBody] InventoryMovementReportRequest request)
        {
            request.isPaged = false;
            var data = _simRepository.GetInventoryMovement(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Mã";
            worksheet.Cell(1, 2).Value = "Tên";
            worksheet.Cell(1, 3).Value = "SL nhập";
            worksheet.Cell(1, 4).Value = "Đơn giá";
            worksheet.Cell(1, 5).Value = "Thành tiền";
            worksheet.Cell(1, 6).Value = "SL còn lại";
            worksheet.Cell(1, 7).Value = "Ngày nhập";
            worksheet.Cell(1, 8).Value = "Nhà cung cấp";
            worksheet.Cell(1, 9).Value = "Kho";
            worksheet.Cell(1, 10).Value = "Ghi chú";

            var groupedProducts = data.Data.GroupBy(t => t.ProductTypeId);

            int currentRow = 2;

            // Iterate through each group
            foreach (var group in groupedProducts)
            {
                // Group label
                worksheet.Cell(currentRow, 1).Value = $"Loại sản phẩm: {group.Key} - {group.First().ProductTypeName}";
                worksheet.Cell(currentRow, 1).Style.Font.Bold = true;
                currentRow++;

                // Iterate through products in the group
                foreach (var product in group)
                {
                    worksheet.Cell(currentRow, 1).Value = product.Code;
                    worksheet.Cell(currentRow, 2).Value = product.Name;
                    worksheet.Cell(currentRow, 3).Value = product.QuantityPurchased;
                    worksheet.Cell(currentRow, 3).Style.NumberFormat.Format = "#,##0";
                    worksheet.Cell(currentRow, 4).Value = product.UnitPrice;
                    worksheet.Cell(currentRow, 4).Style.NumberFormat.Format = "#,##0";
                    worksheet.Cell(currentRow, 5).Value = product.TotalAmount;
                    worksheet.Cell(currentRow, 5).Style.NumberFormat.Format = "#,##0";
                    worksheet.Cell(currentRow, 6).Value = product.RemainingQuantity;
                    worksheet.Cell(currentRow, 6).Style.NumberFormat.Format = "#,##0";
                    worksheet.Cell(currentRow, 7).Value = product.DateOfEntry.ToString("dd/MM/yyyy HH:mm:ss");
                    worksheet.Cell(currentRow, 8).Value = product.Supplier;
                    worksheet.Cell(currentRow, 9).Value = product.Warehouse;
                    worksheet.Cell(currentRow, 10).Value = product.Note;
                    currentRow++;
                }

                // Group the rows
                worksheet.Rows(currentRow - group.Count(), currentRow - 1).Group();
                //currentRow++;
            }

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion

        #region Chi tiết công nợ khách hàng
        [Route("chi-tiet-cong-no-khach-hang")]
        public ActionResult CustomerDebt(Guid userId)
        {
            ViewBag.UserIds = _accountRepository.GetAgentForCombo();
            ViewBag.UserId = userId;
            var agent = _accountRepository.GetUserForEdit(userId);
            @ViewBag.TitleReport = $"Báo cáo các giao dịch của đại lý: {agent?.FullName}";
            return View();
        }
        public ActionResult SearchCustomerDebt([FromBody] CustomerDebtReportRequest request)
        {
            var data = _simRepository.GetCustomerDebt(request);
            return Json(data);
        }
        public ActionResult ExportCustomerDebt([FromBody] CustomerDebtReportRequest request)
        {
            request.isPaged = false;
            var data = _simRepository.GetCustomerDebt(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            //var agent = new UserEditRequest();
            //if (Guid.TryParse(request.agentId, out Guid userId))
            //{
            //    agent = _accountRepository.GetUserForEdit(userId);
            //}

            //// Thêm dữ liệu vào worksheet
            //worksheet.Cell(1, 1).Value = $"Báo cáo các giao dịch của đại lý: {agent?.FullName}. Từ ngày {request.startDate?.ToString("dd/MM/yyyy")} đến hết {request.endDate?.ToString("dd/MM/yyyy")}.";
            //var row1 = worksheet.Range($"A1:N1");
            //row1.Merge();

            var beginningBalance = data?.Data?.FirstOrDefault()?.BeginningBalance ?? 0;
            var incidentalDebt = data?.Data?.Sum(t => t.IncidentalDebt);
            worksheet.Cell(2, 1).Value = $"Nợ đầu kỳ: {beginningBalance.ToString("N0")} đ. Phát sinh trong kỳ: {incidentalDebt?.ToString("N0")} đ. Công nợ cuối kỳ: {(beginningBalance + incidentalDebt)?.ToString("N0")} đ. (Lưu ý: Số âm là nợ đại lý)";
            var row2 = worksheet.Range($"A2:N2");
            row2.Merge();

            worksheet.Cell(3, 1).Value = "Thông tin phiếu";
            worksheet.Cell(3, 5).Value = $"Thông tin phát sinh chi tiết ({data.Data.Count} Sim bán)";
            worksheet.Cell(3, 9).Value = "P/S trong kỳ";
            worksheet.Cell(3, 11).Value = $"{incidentalDebt?.ToString("N0")}đ";
            worksheet.Cell(3, 12).Value = "Thông tin khác";

            var title1 = worksheet.Range($"A3:D3");
            title1.Merge();
            var title2 = worksheet.Range($"E3:H3");
            title2.Merge();
            var title3 = worksheet.Range($"I3:K3");
            title3.Merge();
            var title4 = worksheet.Range($"L3:O3");
            title4.Merge();
            var row3 = worksheet.Range($"A3:N3");
            row3.Style.Font.Bold = true;


            worksheet.Cell(4, 1).Value = "Ngày phát sinh";
            worksheet.Cell(4, 2).Value = "Mã phiếu";
            worksheet.Cell(4, 3).Value = "Loại phiếu";
            worksheet.Cell(4, 4).Value = "Đại lý";
            worksheet.Cell(4, 5).Value = "Số sim";
            worksheet.Cell(4, 6).Value = "Giá niêm yết";
            worksheet.Cell(4, 7).Value = "Giá thu về";
            worksheet.Cell(4, 8).Value = "Phí PS";
            worksheet.Cell(4, 9).Value = "P/S Tăng";
            worksheet.Cell(4, 10).Value = "P/S Giảm";
            worksheet.Cell(4, 11).Value = "Công nợ PS";
            worksheet.Cell(4, 12).Value = "Diễn giải/Ghi chú";
            worksheet.Cell(4, 13).Value = "Hình thức giao dịch";
            worksheet.Cell(4, 14).Value = "COD";
            worksheet.Cell(4, 15).Value = "Người lập";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 5, 1).Value = data.Data[i].TransactionDate.ToString("dd/MM/yyyy HH:mm:ss");
                worksheet.Cell(i + 5, 2).Value = data.Data[i].InvoiceCode;
                worksheet.Cell(i + 5, 3).Value = data.Data[i].InvoiceType;
                worksheet.Cell(i + 5, 4).Value = data.Data[i].AgentName;
                worksheet.Cell(i + 5, 5).Value = data.Data[i].NumberOfSIMs;
                worksheet.Cell(i + 5, 6).Value = data.Data[i].ListedPrice;
                worksheet.Cell(i + 5, 6).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 5, 7).Value = data.Data[i].ActualPriceReceived;
                worksheet.Cell(i + 5, 7).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 5, 8).Value = data.Data[i].IncidentalFee;
                worksheet.Cell(i + 5, 8).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 5, 9).Value = data.Data[i].IncreaseIncidents;
                worksheet.Cell(i + 5, 9).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 5, 10).Value = data.Data[i].DecreaseIncidents;
                worksheet.Cell(i + 5, 10).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 5, 11).Value = data.Data[i].IncidentalDebt;
                worksheet.Cell(i + 5, 11).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 5, 12).Value = data.Data[i].Note;
                worksheet.Cell(i + 5, 13).Value = data.Data[i].TransactionMethod;
                worksheet.Cell(i + 5, 14).Value = data.Data[i].COD;
                worksheet.Cell(i + 5, 14).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 5, 15).Value = data.Data[i].Creator;
            }
            worksheet.Cell(data.Data.Count + 5, 1).Value = "Tổng PS";
            worksheet.Cell(data.Data.Count + 5, 2).Value = data.Data.Count.ToString();
            worksheet.Cell(data.Data.Count + 5, 9).Value = data.Data.Sum(t => t.IncreaseIncidents);
            worksheet.Cell(data.Data.Count + 5, 9).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(data.Data.Count + 5, 10).Value = data.Data.Sum(t => t.DecreaseIncidents);
            worksheet.Cell(data.Data.Count + 5, 10).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(data.Data.Count + 5, 11).Value = data.Data.Sum(t => t.IncidentalDebt);
            worksheet.Cell(data.Data.Count + 5, 11).Style.NumberFormat.Format = "#,##0";
            var rowSum = worksheet.Range($"A{data.Data.Count + 5}:N{data.Data.Count + 5}");
            rowSum.Style.Font.Bold = true;

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion

        #region Log
        [Route("nhat-ki-he-thong")]
        public ActionResult LogSYS()
        {
            ViewBag.Users = _accountRepository.GetListAllUserForCombo();
            return View();
        }
        public ActionResult SearchLogSYS([FromBody] LogSYSRequestModel request)
        {
            var data = _logAction.GetLogSys(request);
            return Json(data);
        }
        public ActionResult ExportLogSYS([FromBody] LogSYSRequestModel request)
        {
            request.isPaged = false;
            var data = _logAction.GetLogSys(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");
            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Ngày phát sinh";
            worksheet.Cell(1, 2).Value = "Người tạo";
            worksheet.Cell(1, 3).Value = "IP";
            worksheet.Cell(1, 4).Value = "Hành động";
            worksheet.Cell(1, 5).Value = "Dữ liệu cũ";
            worksheet.Cell(1, 6).Value = "Dữ liệu mới";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = data.Data[i].createTime.ToString("dd/MM/yyyy HH:mm:ss"); ;
                worksheet.Cell(i + 2, 2).Value = data.Data[i].createBy;
                worksheet.Cell(i + 2, 3).Value = data.Data[i].ipAddressUser;
                worksheet.Cell(i + 2, 4).Value = data.Data[i].actionName;
                worksheet.Cell(i + 2, 5).Value = data.Data[i].oldData;
                worksheet.Cell(i + 2, 6).Value = data.Data[i].newData;
            }

            var usedRange = worksheet.RangeUsed();
            usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Lưu workbook vào một MemoryStream
            var stream = new System.IO.MemoryStream();
            workbook.SaveAs(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // Trả về một FileResult
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "export.xlsx");
        }
        #endregion
    }
}
