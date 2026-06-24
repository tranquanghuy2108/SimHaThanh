using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;
using Repositories.Implement;
using Repositories.Interface;
using System.Security.Claims;

namespace WebSIMManager.Controllers
{
    public class BankController : BaseController
    {
        private readonly IBankRepository _bankRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public BankController(IBankRepository bankRepository, IHttpContextAccessor httpContextAccessor)
        {
            _bankRepository = bankRepository;
            _httpContextAccessor = httpContextAccessor;
        }
        // GET: BankController
        [Authorize(Roles = "Xem danh sách tk bank")]
        public ActionResult Index()
        {
            ViewBag.DataView = _bankRepository.GetBank().Data;
            return View();
        }

        // GET: BankController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [Route("add-bank")]
        // GET: BankController/Create
        [Authorize(Roles = "Tạo mới tk bank")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-bank")]
        [Authorize(Roles = "Tạo mới tk bank")]
        public ActionResult Create(BankModels model)
        {
            try
            {
                //Get role list
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = _bankRepository.Create(model, userActionId);
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(model);
                }
            }
            catch
            {
                return View();
            }
        }

        [Route("edit-bank")]
        [Authorize(Roles = "Sửa tk bank")]
        // GET: BankController/Edit/5
        public ActionResult Edit(int id)
        {
            var dataEdit = _bankRepository.Detail(id);
            return View(dataEdit);
        }

        // POST: BankController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-bank")]
        [Authorize(Roles = "Sửa tk bank")]
        public ActionResult Edit(BankModels model)
        {
            try
            {
                //Get role list
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = _bankRepository.Update(model, userActionId);
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(model);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: BankController/Delete/5
        [Authorize(Roles = "Xóa tk bank")]
        public ActionResult Delete(int id)
        {
            try
            {
                var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = _bankRepository.Delete(id, userActionId);

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
    }
}
