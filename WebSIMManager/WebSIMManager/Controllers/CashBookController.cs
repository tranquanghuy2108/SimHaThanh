using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;
using Repositories.Interface;
using System.Security.Claims;

namespace WebSIMManager.Controllers
{
    public class CashBookController : Controller
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ICashBookRepository _cashBookRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CashBookController(IHttpContextAccessor contextAccessor, ICashBookRepository cashBookRepository, IAccountRepository accountRepository, IHttpContextAccessor httpContextAccessor)
        {
            _contextAccessor = contextAccessor;
            _cashBookRepository = cashBookRepository;
            _accountRepository = accountRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: CashBookController
        public ActionResult Index()
        {
            ViewBag.AppUsers = _accountRepository.GetCusAgentForCombo();
            return View();
        }

        public ActionResult Search([FromBody] GetCashBookPagingRequest request)
        {
            request.pageIndex = request.pageIndex == 0 ? 1 : request.pageIndex;
            request.pageSize = 10;

            var data = _cashBookRepository.GetCashBookPaging(request);
            return Json(data);
        }
        [Authorize(Roles = "Duyệt kí quỹ")]
        public ActionResult OnApproved([FromBody] ApprovedDebtRequest request)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = _cashBookRepository.ApprovedCashBook(request.debtIds, request.status, new Guid(userId));
            return Json(data);
        }
    }
}
