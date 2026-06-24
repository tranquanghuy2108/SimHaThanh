using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;
using Repositories.Implement;
using Repositories.Interface;
using System.Security.Claims;

namespace WebSIMManager.Controllers
{
    [Authorize]
    public class CountryController : BaseController
    {
        private readonly ISystemConfigRepository _sysConfigRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CountryController(ISystemConfigRepository sysConfigRepository, IHttpContextAccessor httpContextAccessor)
        {
            _sysConfigRepository = sysConfigRepository;
            _httpContextAccessor = httpContextAccessor;
        }
        // GET: countryController
        //[Authorize(Roles = "Xem danh sách tk country")]
        public ActionResult Index()
        {
            ViewBag.DataView = _sysConfigRepository.GetCountry().Data;
            return View();
        }

        // GET: countryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [Route("add-country")]
        // GET: countryController/Create
        //[Authorize(Roles = "Tạo mới tk country")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: countryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-country")]
        //[Authorize(Roles = "Tạo mới tk country")]
        public ActionResult Create(CountryModels model)
        {
            try
            {
                //Get role list
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = _sysConfigRepository.CreateCountry(model, userActionId);
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

        [Route("edit-country")]
        //[Authorize(Roles = "Sửa tk country")]
        // GET: countryController/Edit/5
        public ActionResult Edit(int id)
        {
            var dataEdit = _sysConfigRepository.GetCountryById(id);
            return View(dataEdit);
        }

        // POST: countryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-country")]
        //[Authorize(Roles = "Sửa tk country")]
        public ActionResult Edit(CountryModels model)
        {
            try
            {
                //Get role list
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = _sysConfigRepository.UpdateCountry(model, userActionId);
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

        // GET: countryController/Delete/5
        //[Authorize(Roles = "Xóa tk country")]
        public ActionResult Delete(int id)
        {
            try
            {
                var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = _sysConfigRepository.DeleteCountry(id, userActionId);

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
