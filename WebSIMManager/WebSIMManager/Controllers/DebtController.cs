using ClosedXML.Excel;
using Commons.Enums;
using DocumentFormat.OpenXml.Office2016.Excel;
using EFCoreMySQL.EntityModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Models.Requests;
using Models.ViewModels;
using Repositories.Implement;
using Repositories.Interface;
using System.Security.Claims;

namespace WebSIMManager.Controllers
{
    public class DebtController : BaseController
    {
        private readonly IDebtRepository _debtRepository;
        private readonly IAccountRepository _AccountRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _environment;
        private readonly ISIMRepository _simRepository;
        private readonly IBankRepository _bankRepository;
        public DebtController(IDebtRepository debtRepository, IAccountRepository accountRepository, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment environment, ISIMRepository simRepository, IBankRepository bankRepository)
        {
            _debtRepository = debtRepository;
            _AccountRepository = accountRepository;
            _httpContextAccessor = httpContextAccessor;
            _environment = environment;
            _simRepository = simRepository;
            _bankRepository = bankRepository;
        }
        // GET: DebtController
        [Authorize(Roles = "Xem công nợ phát sinh")]
        public ActionResult Index()
        {
            ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
            ViewBag.Staff = _AccountRepository.GetStaffForCombo();
            List<SelectListItem> selectListItems = new List<SelectListItem>()
            {
                new SelectListItem() { Value = ((int)ApprovedStatus.Waiting).ToString(), Text= Enum.GetName(typeof(ApprovedStatus),ApprovedStatus.Waiting)},
                new SelectListItem() { Value = ((int)ApprovedStatus.Approved).ToString(), Text= Enum.GetName(typeof(ApprovedStatus),ApprovedStatus.Approved)},
                new SelectListItem() { Value = ((int)ApprovedStatus.Reject).ToString(), Text= Enum.GetName(typeof(ApprovedStatus),ApprovedStatus.Reject)},
            };
            @ViewBag.Status = selectListItems;
            return View();
        }
        // GET: DebtController
        public ActionResult SearchDebt([FromBody] DebtFilterRequest request)
        {
            //request.userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = _debtRepository.GetDebtForFilter(request);
            return Json(data);
        }
        [Route("my-debt")]
        [Authorize(Roles = "Xem công nợ của mình")]
        // GET: DebtController
        public ActionResult MyDebt()
        {
            ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
            List<SelectListItem> selectListItems = new List<SelectListItem>()
            {
                new SelectListItem() { Value = ((int)ApprovedStatus.Waiting).ToString(), Text= Enum.GetName(typeof(ApprovedStatus),ApprovedStatus.Waiting)},
                new SelectListItem() { Value = ((int)ApprovedStatus.Approved).ToString(), Text= Enum.GetName(typeof(ApprovedStatus),ApprovedStatus.Approved)},
                new SelectListItem() { Value = ((int)ApprovedStatus.Reject).ToString(), Text= Enum.GetName(typeof(ApprovedStatus),ApprovedStatus.Reject)},
            };
            @ViewBag.Status = selectListItems;
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.UserIds = _AccountRepository.GetStaffForCombo();
            ViewBag.UserId = userId;
            ViewBag.debtType = (int)DebtCategory.Staff;
            return View();
        }
        // GET: DebtController
        public ActionResult SearchMyDebt([FromBody] DebtFilterRequest request)
        {
            request.userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = _debtRepository.GetDebtForFilter(request);
            return Json(data);
        }
        [Route("waiting-appr-debt")]
        [Authorize(Roles = "Xóa đơn hỏi mua")]
        // GET: DebtController
        public ActionResult WaitingAppr()
        {
            @ViewBag.Pics = _AccountRepository.GetStaffForCombo();
            @ViewBag.Agents = _AccountRepository.GetAgentForCombo();
            return View();
        }

        // GET: DebtController
        public ActionResult SearchWaitingApprDebt([FromBody] DebtFilterModel request)
        {
            request.approvedStatus = Commons.Enums.ApprovedStatus.Waiting;
            request.pageIndex = request.pageIndex == 0 ? 1 : request.pageIndex;
            request.pageSize = 50;

            var data = _debtRepository.GetDebt(request);
            return Json(data);
        }
        // GET: DebtController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        #region Công nợ phát sinh
        [Route("create-debt")]
        [Authorize(Roles = "Tạo mới công nợ")]
        // GET: DebtController/Create
        public ActionResult Create()
        {
            @ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
            ViewBag.DebtTypes = _debtRepository.GetDebtTypeForCombo();
            return View();
        }

        // POST: DebtController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create-debt")]
        [Authorize(Roles = "Tạo mới công nợ")]
        public ActionResult Create(DebtModels request)
        {
            try
            {
                @ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
                ViewBag.DebtTypes = _debtRepository.GetDebtTypeForCombo();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }
                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = _debtRepository.Create(request, userId);
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

        [Route("edit-debt")]
        [Authorize(Roles = "Sửa công nợ")]
        // GET: DebtController/Edit/5
        public ActionResult Edit(int id)
        {
            @ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
            ViewBag.DebtTypes = _debtRepository.GetDebtTypeForCombo();
            var debt = _debtRepository.Detail(id);
            @ViewBag.EnableEdit = debt.approvedStatus == ApprovedStatus.Waiting;
            return View(debt);
        }

        // POST: DebtController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-debt")]
        [Authorize(Roles = "Sửa công nợ")]
        public ActionResult Edit(DebtModels request)
        {
            try
            {
                @ViewBag.Agents = _AccountRepository.GetCusAgentForCombo();
                ViewBag.DebtTypes = _debtRepository.GetDebtTypeForCombo();
                @ViewBag.EnableEdit = request.approvedStatus == ApprovedStatus.Waiting;
                if (!ModelState.IsValid)
                {
                    return View(request);
                }
                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = _debtRepository.Update(request, userId);
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

        // GET: DebtController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        //

        [Authorize(Roles = "Duyệt công nợ")]
        public ActionResult OnApprovedCNPS([FromBody] ApprovedDebtRequest request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = _debtRepository.Approved(request.debtIds, request.status, userId);
            return Json(data);
        }

        #endregion

        #region Loại công nợ phát sinh
        [Route("debt-type")]
        [Authorize(Roles = "Xem loại công nợ")]
        public ActionResult DebtType(GetPagingRequest request)
        {
            if (request.keyword == null)
                request.keyword = "";
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageSize = 50;

            var data = _debtRepository.GetDebtType(request);
            if (data != null)
            {
                @ViewBag.DataView = data.Data;
                @ViewBag.Pager = data.Pager;
            }

            return View();
        }
        [Route("create-debt-type")]
        [Authorize(Roles = "Tạo mới loại công nợ")]
        // GET: DebtController/Create
        public ActionResult CreateDebtType()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>()
            {
                new SelectListItem() { Value = ((int)DebtReceiveType.All).ToString(), Text= "Phát sinh thu/chi"},
                new SelectListItem() { Value = ((int)DebtReceiveType.Receivables).ToString(), Text= "Phát sinh thu"},
                new SelectListItem() { Value = ((int)DebtReceiveType.Liabilities).ToString(), Text= "Phát sinh chi"},
            };
            @ViewBag.DebtReceiveTypes = selectListItems;
            return View();
        }

        // POST: DebtController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create-debt-type")]
        [Authorize(Roles = "Tạo mới loại công nợ")]
        public ActionResult CreateDebtType(DebtTypeModel request)
        {
            try
            {
                List<SelectListItem> selectListItems = new List<SelectListItem>()
                {
                    new SelectListItem() { Value = ((int)DebtReceiveType.All).ToString(), Text= "Phát sinh thu/chi"},
                    new SelectListItem() { Value = ((int)DebtReceiveType.Receivables).ToString(), Text= "Phát sinh thu"},
                    new SelectListItem() { Value = ((int)DebtReceiveType.Liabilities).ToString(), Text= "Phát sinh chi"},
                };
                @ViewBag.DebtReceiveTypes = selectListItems;
                if (!ModelState.IsValid)
                {
                    return View(request);
                }
                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = _debtRepository.CreateDebtType(request, userId);
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(DebtType));
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

        [Route("edit-debt-type")]
        [Authorize(Roles = "Sửa loại công nợ")]
        // GET: DebtController/Edit/5
        public ActionResult EditDebtType(int id)
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>()
            {
                new SelectListItem() { Value = ((int)DebtReceiveType.All).ToString(), Text= "Phát sinh thu/chi"},
                new SelectListItem() { Value = ((int)DebtReceiveType.Receivables).ToString(), Text= "Phát sinh thu"},
                new SelectListItem() { Value = ((int)DebtReceiveType.Liabilities).ToString(), Text= "Phát sinh chi"},
            };
            @ViewBag.DebtReceiveTypes = selectListItems;
            var debt = _debtRepository.DetailDebtType(id);
            return View(debt);
        }

        // POST: DebtController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-debt-type")]
        [Authorize(Roles = "Sửa loại công nợ")]
        public ActionResult EditDebtType(DebtTypeModel request)
        {
            try
            {
                List<SelectListItem> selectListItems = new List<SelectListItem>()
                {
                    new SelectListItem() { Value = ((int)DebtReceiveType.All).ToString(), Text= "Phát sinh thu/chi"},
                    new SelectListItem() { Value = ((int)DebtReceiveType.Receivables).ToString(), Text= "Phát sinh thu"},
                    new SelectListItem() { Value = ((int)DebtReceiveType.Liabilities).ToString(), Text= "Phát sinh chi"},
                };
                @ViewBag.DebtReceiveTypes = selectListItems;
                if (!ModelState.IsValid)
                {
                    return View(request);
                }
                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = _debtRepository.UpdateDebtType(request, userId);
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(DebtType));
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

        // GET: DebtController/Delete/5
        [Authorize(Roles = "Xóa loại công nợ")]
        public ActionResult DeleteDebtType(int id)
        {
            try
            {
                var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = _debtRepository.DeleteDebtType(id, userActionId);

                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(DebtType));
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
        #endregion

        #region Chuyển tiền
        [Route("transfer-money")]
        [Authorize(Roles = "Xem phiếu chuyển tiền")]
        public ActionResult TransferMoney(TransferMoneyFilterModel request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (request.keyword == null)
                request.keyword = "";
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageSize = 50;
            request.ReceiverId = userId;
            var data = _debtRepository.GetTransferMoney(request);
            if (data != null)
            {
                @ViewBag.DataView = data.Data;
                @ViewBag.Pager = data.Pager;
            }

            return View();
        }
        // POST: DebtController/Create
        [HttpPost]
        [Route("create-transfer-money")]
        [Authorize(Roles = "Tạo mới phiếu chuyển tiền")]
        public ActionResult CreateTransferMoney([FromBody] CreateTransferMoneyModel request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            TransferMoneyModel transferMoneyModel = new TransferMoneyModel()
            {
                Amount = request.Amount,
                DebtStaffIds = request.DebtStaffIds,
                Description = request.Description,
                Note = request.Note,
                RemittersId = new Guid(userId),
                ReceiverId = new Guid(request.ReceiverId)
            };
            var result = _debtRepository.CreateTransferMoney(transferMoneyModel, userId);
            return Json(result);
        }

        [Route("edit-transfer-money")]
        [Authorize(Roles = "Sửa phiếu chuyển tiền")]
        // GET: DebtController/Edit/5
        public ActionResult EditTransferMoney(int id)
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>()
            {
                new SelectListItem() { Value = ((int)DebtReceiveType.All).ToString(), Text= "Phát sinh thu/chi"},
                new SelectListItem() { Value = ((int)DebtReceiveType.Receivables).ToString(), Text= "Phát sinh thu"},
                new SelectListItem() { Value = ((int)DebtReceiveType.Liabilities).ToString(), Text= "Phát sinh chi"},
            };
            @ViewBag.DebtReceiveTypes = selectListItems;
            var debt = _debtRepository.DetailTransferMoney(id);
            return View(debt);
        }

        // POST: DebtController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-transfer-money")]
        [Authorize(Roles = "Sửa phiếu chuyển tiền")]
        public ActionResult EditTransferMoney(TransferMoneyModel request)
        {
            try
            {
                List<SelectListItem> selectListItems = new List<SelectListItem>()
                {
                    new SelectListItem() { Value = ((int)DebtReceiveType.All).ToString(), Text= "Phát sinh thu/chi"},
                    new SelectListItem() { Value = ((int)DebtReceiveType.Receivables).ToString(), Text= "Phát sinh thu"},
                    new SelectListItem() { Value = ((int)DebtReceiveType.Liabilities).ToString(), Text= "Phát sinh chi"},
                };
                @ViewBag.DebtReceiveTypes = selectListItems;
                if (!ModelState.IsValid)
                {
                    return View(request);
                }
                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = _debtRepository.UpdateTransferMoney(request, userId);
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(TransferMoney));
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

        // GET: DebtController/Delete/5
        [Authorize(Roles = "Xóa phiếu chuyển tiền")]
        public ActionResult DeleteTransferMoney(int id)
        {
            var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
            var result = _debtRepository.DeleteTransferMoney(id, userActionId);
            return Json(result);
        }

        [Authorize(Roles = "Duyệt phiếu chuyển tiền")]
        public ActionResult OnApprovedTransferMoney([FromBody] TransferMoneApprovedModel request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = _debtRepository.ApprovedTransferMoney(request, userId);
            return Json(data);
        }
        public ActionResult CheckTransferMoneyLst([FromBody] CheckTransferMoneyRequestModel request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = _debtRepository.CheckTransferMoneyLst(request.DebtStaffIds);
            return Json(data);
        }

        #endregion

        #region Phiếu thu
        [Route("receipt")]
        [Authorize(Roles = "Xem phiếu thu tiền")]
        public ActionResult Receipt(ReceiptFilterModel request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (request.keyword == null)
                request.keyword = "";
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageSize = 50;
            var data = _debtRepository.GetReceipt(request);
            if (data != null)
            {
                @ViewBag.DataView = data.Data;
                @ViewBag.Pager = data.Pager;
            }

            return View();
        }
        // POST: DebtController/Create
        [Route("create-receipt")]
        [Authorize(Roles = "Tạo mới phiếu thu tiền")]
        public ActionResult CreateReceipt(string agentId)
        {
            //var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userInfo = _AccountRepository.GetUserForEdit(new Guid(agentId));
            ViewBag.UserInfo = userInfo;
            List<SelectListItem> selectListItems = new List<SelectListItem>()
            {
                new SelectListItem() { Value = ((int)FormOfPayment.Direct).ToString(), Text= "Thanh toán trực tiếp"},
                new SelectListItem() { Value = ((int)FormOfPayment.Banking).ToString(), Text= "Chuyển khoản"},
            };
            @ViewBag.FormOfPayment = selectListItems;
            List<SelectListItem> selectListItems1 = new List<SelectListItem>()
            {
                new SelectListItem() { Value = ((int)TypeOfReceived.Thu).ToString(), Text= "Phiếu thu"},
                new SelectListItem() { Value = ((int)TypeOfReceived.Chi).ToString(), Text= "Phiếu chi"},
            };
            @ViewBag.TypeOfReceived = selectListItems1;
            ViewBag.Agents = _AccountRepository.GetAgentForCombo();
            ViewBag.Banks = _bankRepository.GetBankForCombo();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create-receipt")]
        [Authorize(Roles = "Tạo mới phiếu thu tiền")]
        public ActionResult CreateReceipt(ReceiptModel request)
        {
            try
            {
				var userInfo = _AccountRepository.GetUserForEdit(request.AgentId);
				ViewBag.UserInfo = userInfo;
				List<SelectListItem> selectListItems = new List<SelectListItem>()
			{
				new SelectListItem() { Value = ((int)FormOfPayment.Direct).ToString(), Text= "Thanh toán trực tiếp"},
				new SelectListItem() { Value = ((int)FormOfPayment.Banking).ToString(), Text= "Chuyển khoản"},
			};
				@ViewBag.FormOfPayment = selectListItems;
				List<SelectListItem> selectListItems1 = new List<SelectListItem>()
			{
				new SelectListItem() { Value = ((int)TypeOfReceived.Thu).ToString(), Text= "Phiếu thu"},
				new SelectListItem() { Value = ((int)TypeOfReceived.Chi).ToString(), Text= "Phiếu chi"},
			};
				@ViewBag.TypeOfReceived = selectListItems1;
				ViewBag.Agents = _AccountRepository.GetAgentForCombo();
				ViewBag.Banks = _bankRepository.GetBankForCombo();
				if (!ModelState.IsValid)
                {
                    return View(request);
                }
                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = _debtRepository.CreateReceipt(request, userId);
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(Receipt));
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

        [Route("receipt-detail")]
        [Authorize(Roles = "Xem phiếu thu tiền")]
        // GET: DebtController/Edit/5
        public ActionResult ReceiptDetail(int id)
        {
			List<SelectListItem> selectListItems = new List<SelectListItem>()
			{
				new SelectListItem() { Value = ((int)FormOfPayment.Direct).ToString(), Text= "Thanh toán trực tiếp"},
				new SelectListItem() { Value = ((int)FormOfPayment.Banking).ToString(), Text= "Chuyển khoản"},
			};
			@ViewBag.FormOfPayment = selectListItems;
            List<SelectListItem> selectListItems1 = new List<SelectListItem>()
            {
                new SelectListItem() { Value = ((int)TypeOfReceived.Thu).ToString(), Text= "Phiếu thu"},
                new SelectListItem() { Value = ((int)TypeOfReceived.Chi).ToString(), Text= "Phiếu chi"},
            };
            @ViewBag.TypeOfReceived = selectListItems1;
            ViewBag.Agents = _AccountRepository.GetAgentForCombo();
            ViewBag.Staffs = _AccountRepository.GetStaffForCombo();
			ViewBag.Banks = _bankRepository.GetBankForCombo();
			var debt = _debtRepository.DetailReceipt(id);
            return View(debt);
        }

        [Route("edit-receipt")]
        [Authorize(Roles = "Sửa phiếu thu tiền")]
        // GET: DebtController/Edit/5
        public ActionResult EditReceipt(int id)
        {
			List<SelectListItem> selectListItems = new List<SelectListItem>()
			{
				new SelectListItem() { Value = ((int)FormOfPayment.Direct).ToString(), Text= "Thanh toán trực tiếp"},
				new SelectListItem() { Value = ((int)FormOfPayment.Banking).ToString(), Text= "Chuyển khoản"},
			};
			@ViewBag.FormOfPayment = selectListItems;
            List<SelectListItem> selectListItems1 = new List<SelectListItem>()
            {
                new SelectListItem() { Value = ((int)TypeOfReceived.Thu).ToString(), Text= "Phiếu thu"},
                new SelectListItem() { Value = ((int)TypeOfReceived.Chi).ToString(), Text= "Phiếu chi"},
            };
            @ViewBag.TypeOfReceived = selectListItems1;
            ViewBag.Agents = _AccountRepository.GetAgentForCombo();
            ViewBag.Staffs = _AccountRepository.GetStaffForCombo();
			ViewBag.Banks = _bankRepository.GetBankForCombo();
			var debt = _debtRepository.DetailReceipt(id);
            return View(debt);
        }

        // POST: DebtController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-receipt")]
        [Authorize(Roles = "Sửa phiếu thu tiền")]
        public ActionResult EditReceipt(ReceiptModel request)
        {
            try
            {
				List<SelectListItem> selectListItems = new List<SelectListItem>()
			{
				new SelectListItem() { Value = ((int)FormOfPayment.Direct).ToString(), Text= "Thanh toán trực tiếp"},
				new SelectListItem() { Value = ((int)FormOfPayment.Banking).ToString(), Text= "Chuyển khoản"},
			};
				@ViewBag.FormOfPayment = selectListItems;
                List<SelectListItem> selectListItems1 = new List<SelectListItem>()
            {
                new SelectListItem() { Value = ((int)TypeOfReceived.Thu).ToString(), Text= "Phiếu thu"},
                new SelectListItem() { Value = ((int)TypeOfReceived.Chi).ToString(), Text= "Phiếu chi"},
            };
                @ViewBag.TypeOfReceived = selectListItems1;
                ViewBag.Agents = _AccountRepository.GetAgentForCombo();
				ViewBag.Staffs = _AccountRepository.GetStaffForCombo();
				ViewBag.Banks = _bankRepository.GetBankForCombo();
				if (!ModelState.IsValid)
                {
                    return View(request);
                }
                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = _debtRepository.UpdateReceipt(request, userId);
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(Receipt));
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

        // GET: DebtController/Delete/5
        [Authorize(Roles = "Xóa phiếu thu tiền")]
        public ActionResult DeleteReceipt(int id)
        {
            var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
            var result = _debtRepository.DeleteReceipt(id, userActionId);
            return Json(result);
        }

        [Authorize(Roles = "Duyệt phiếu thu tiền")]
        public ActionResult OnApprovedReceipt([FromBody] ReceiptApprovedModel request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = _debtRepository.ApprovedReceipt(request, userId);
            return Json(data);
        }
        //public ActionResult CheckReceiptLst([FromBody] CheckReceiptRequestModel request)
        //{
        //    var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    var data = _debtRepository.CheckReceiptLst(request.DebtStaffIds);
        //    return Json(data);
        //}

        public ActionResult CheckOldDebtOfAgent([FromBody] DebtOfAgentRequest request)
		{
			var data = _debtRepository.CheckOldDebtOfAgent(request);
			return Json(data);
		}
		#endregion

		#region Report

		#region Tiền tồn trong quỹ
		[Route("tien-ton-trong-quy1")]
        public ActionResult CashFundBalance()
        {
            return View();
        }
        public ActionResult SearchCashFundBalance([FromBody] CashFundBalanceReportRequest request)
        {
            var data = _debtRepository.GetCashFundBalance(request);
            return Json(data);
        }
        [Route("chi-tiet-tien-ton-trong-quy")]
        public ActionResult CashFundBalanceDetail(string userId, DebtCategory debtType)
        {
            ViewBag.UserIds = _AccountRepository.GetStaffForCombo();
            ViewBag.UserId = userId;
            ViewBag.debtType = (int)debtType;
            return View();
        }
        public ActionResult SearchCashFundBalanceDetail([FromBody] DebtDetailFilterModel request)
        {
            var data = _debtRepository.GetDebtDetail(request);
            return Json(data);
        }
        public ActionResult ExportCashFundBalance([FromBody] CashFundBalanceReportRequest request)
        {
            request.isPaged = false;
            var data = _debtRepository.GetCashFundBalance(request);

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

        public ActionResult ConfirmDebtSettlementOfStaff([FromBody] ApprovedDebtRequest request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = _debtRepository.ConfirmDebtSettlementOfStaff(request.debtIds, true, userId);
            return Json(data);
        }
        #endregion

        #region Tiền tồn trong ngân hàng
        [Route("tien-ton-trong-bank")]
        public ActionResult BankFundBalance()
        {
            return View();
        }
        public ActionResult SearchBankFundBalance([FromBody] CashFundBalanceReportRequest request)
        {
            var data = _debtRepository.GetBankFundBalance(request);
            return Json(data);
        }
        [Route("chi-tiet-tien-ton-trong-bank")]
        public ActionResult BankFundBalanceDetail(string id, DebtCategory debtType)
        {
            ViewBag.userId = id;
            ViewBag.debtType = (int)debtType;
            return View();
        }
        public ActionResult SearchDebtBankDetail([FromBody] DebtDetailFilterModel request)
        {
            var data = _debtRepository.GetDebtBankDetail(request);
            return Json(data);
        }
        public ActionResult ExportBankFundBalance([FromBody] CashFundBalanceReportRequest request)
        {
            request.isPaged = false;
            var data = _simRepository.GetCashFundBalance(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Quỹ";
            worksheet.Cell(1, 2).Value = "Số dư hiện tại";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = data.Data[i].StaffName;
                worksheet.Cell(i + 2, 2).Value = data.Data[i].CurrentBalance;
                worksheet.Cell(i + 2, 2).Style.NumberFormat.Format = "#,##0";
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

        public ActionResult ConfirmDebtSettlementOfBank([FromBody] ApprovedDebtRequest request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = _debtRepository.ConfirmDebtSettlementOfBank(request.debtIds, true, userId);
            return Json(data);
        }
        #endregion

        #region Tiền tồn trong đơn vị vận chuyển
        [Route("tien-ton-trong-shipping")]
        public ActionResult ShippingFundBalance()
        {
            return View();
        }
        public ActionResult SearchShippingFundBalance([FromBody] CashFundBalanceReportRequest request)
        {
            var data = _debtRepository.GetShippingFundBalance(request);
            return Json(data);
        }
        [Route("chi-tiet-tien-ton-trong-shipping")]
        public ActionResult ShippingFundBalanceDetail(string userId, DebtCategory debtType)
        {
            ViewBag.userId = userId;
            ViewBag.debtType = (int)debtType;
            return View();
        }
        public ActionResult SearchShippingFundBalanceDetail([FromBody] DebtDetailFilterModel request)
        {
            var data = _debtRepository.GetDebtShippingDetail(request);
            return Json(data);
        }
        public ActionResult ExportShippingFundBalance([FromBody] CashFundBalanceReportRequest request)
        {
            var data = _debtRepository.GetShippingFundBalance(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Quỹ";
            worksheet.Cell(1, 2).Value = "Tổng tiền";
            worksheet.Cell(1, 3).Value = "Số dư hiện tại";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = data.Data[i].ShippingInfo;
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

        public ActionResult ConfirmDebtSettlementOfShipping([FromBody] ApprovedDebtRequest request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = _debtRepository.ConfirmDebtSettlementOfShipping(request.debtIds, true, userId);
            return Json(data);
        }

        public ActionResult ExportDebtBankDetail([FromBody] DebtDetailFilterModel request)
        {
            var data = _debtRepository.GetDebtBankDetail(request);

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
                worksheet.Cell(i + 2, 1).Value = data.Data[i].createTime;
                worksheet.Cell(i + 2, 2).Value = data.Data[i].DebtCode;
                worksheet.Cell(i + 2, 3).Value = data.Data[i].PIC;
                worksheet.Cell(i + 2, 4).Value = data.Data[i].Receivables;
                worksheet.Cell(i + 2, 4).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 5).Value = data.Data[i].Liabilities;
                worksheet.Cell(i + 2, 5).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 6).Value = data.Data[i].Description;
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
        public ActionResult ExportCashFundBalanceDetail([FromBody] DebtDetailFilterModel request)
        {
            var data = _debtRepository.GetDebtDetail(request);

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
                worksheet.Cell(i + 2, 1).Value = data.Data[i].createTime;
                worksheet.Cell(i + 2, 2).Value = data.Data[i].DebtCode;
                worksheet.Cell(i + 2, 3).Value = data.Data[i].PIC;
                worksheet.Cell(i + 2, 4).Value = data.Data[i].Receivables;
                worksheet.Cell(i + 2, 4).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 5).Value = data.Data[i].Liabilities;
                worksheet.Cell(i + 2, 5).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 6).Value = data.Data[i].Description;
                worksheet.Cell(i + 2, 7).Value = data.Data[i].Note;
            }
            worksheet.Cell(data.Data.Count + 2, 1).Value = "Tổng phiếu";
            worksheet.Cell(data.Data.Count + 2, 2).Value = data.Data.Count.ToString();
            worksheet.Cell(data.Data.Count + 2, 4).Value = data.Data.Sum(t => t.Receivables);
            worksheet.Cell(data.Data.Count + 2, 4).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(data.Data.Count + 2, 5).Value = data.Data.Sum(t => t.Liabilities);
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
        public ActionResult ExportShippingFundBalanceDetail([FromBody] DebtDetailFilterModel request)
        {
            var data = _debtRepository.GetDebtShippingDetail(request);

            // Tạo một workbook mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Thêm dữ liệu vào worksheet
            worksheet.Cell(1, 1).Value = "Ngày phát sinh";
            worksheet.Cell(1, 2).Value = "Mã phiếu";
            worksheet.Cell(1, 3).Value = "Đơn vị vận chuyển";
            worksheet.Cell(1, 4).Value = "Thu";
            worksheet.Cell(1, 5).Value = "Chi";
            worksheet.Cell(1, 6).Value = "Diễn giải";
            worksheet.Cell(1, 7).Value = "Ghi chú";

            for (int i = 0; i < data.Data.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = data.Data[i].createTime;
                worksheet.Cell(i + 2, 2).Value = data.Data[i].DebtCode;
                worksheet.Cell(i + 2, 3).Value = data.Data[i].PIC;
                worksheet.Cell(i + 2, 4).Value = data.Data[i].Receivables;
                worksheet.Cell(i + 2, 4).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 5).Value = data.Data[i].Liabilities;
                worksheet.Cell(i + 2, 5).Style.NumberFormat.Format = "#,##0";
                worksheet.Cell(i + 2, 6).Value = data.Data[i].Description;
                worksheet.Cell(i + 2, 7).Value = data.Data[i].Note;
            }
            worksheet.Cell(data.Data.Count + 2, 1).Value = "Tổng phiếu";
            worksheet.Cell(data.Data.Count + 2, 2).Value = data.Data.Count.ToString();
            worksheet.Cell(data.Data.Count + 2, 4).Value = data.Data.Sum(t => t.Receivables);
            worksheet.Cell(data.Data.Count + 2, 4).Style.NumberFormat.Format = "#,##0";
            worksheet.Cell(data.Data.Count + 2, 5).Value = data.Data.Sum(t => t.Liabilities);
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
        #endregion
    }
}
