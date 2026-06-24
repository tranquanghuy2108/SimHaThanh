using DocumentFormat.OpenXml.Office2010.CustomUI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Requests;
using Models.ViewModels;
using Repositories.Interface;
using System.Security.Claims;

namespace WebSIMManager.Controllers
{
    [Authorize]
    public class ProductTypeController : BaseController
    {
        private readonly ISIMRepository _SIMRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ISystemConfigRepository _systemConfigRepository;
        public ProductTypeController(ISIMRepository SIMRepository, IHttpContextAccessor httpContextAccessor, ISystemConfigRepository systemConfigRepository)
        {
            _SIMRepository = SIMRepository;
            _httpContextAccessor = httpContextAccessor;
            _systemConfigRepository = systemConfigRepository;
        }
        // GET: SIMTypeController
        [Authorize(Roles = "Xem loại sim")]
        public ActionResult Index(GetPagingRequest request)
        {
            if (request.keyword == null)
                request.keyword = "";
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageSize = 50;

            var data = _SIMRepository.GetProductTypePaging(request);
            if (data != null)
            {
                @ViewBag.DataView = data.Data;
                @ViewBag.Pager = data.Pager;
            }

            return View();
        }

        // GET: SIMTypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SIMTypeController/Create
        [Route("add-product-type")]
        [Authorize(Roles = "Tạo mới loại sim")]
        public ActionResult Create()
        {
            ViewBag.Contries = _systemConfigRepository.GetCountryForCombo();
            return View();
        }

        // POST: SIMTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-product-type")]
        [Authorize(Roles = "Tạo mới loại sim")]
        public ActionResult Create(ProductTypeModel request)
        {
            try
            {
                ViewBag.Contries = _systemConfigRepository.GetCountryForCombo();
                request.CreateBy = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _SIMRepository.CreateProductType(request);
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

        // GET: SIMTypeController/Edit/5
        [Route("edit-product-type")]
        [Authorize(Roles = "Sửa loại sim")]
        public ActionResult Edit(int id)
        {
            ViewBag.Contries = _systemConfigRepository.GetCountryForCombo();
            var data = _SIMRepository.GetProductTypeById(id);
            return View(data);
        }

        // POST: SIMTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-product-type")]
        [Authorize(Roles = "Sửa loại sim")]
        public ActionResult Edit(ProductTypeModel request)
        {
            try
            {
                ViewBag.Contries = _systemConfigRepository.GetCountryForCombo();
                request.CreateBy = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _SIMRepository.UpdateProductType(request);
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

        // POST: SIMTypeController/Delete/5
        [HttpGet]
        [Authorize(Roles = "Xóa loại sim")]
        public ActionResult Delete(int id)
        {
            try
            {
                var userId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = _SIMRepository.DeleteProductType(id, userId);

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
