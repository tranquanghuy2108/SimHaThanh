using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;
using Repositories.Implement;
using Repositories.Interface;
using System.Security.Claims;

namespace WebSIMManager.Controllers
{
    public class ShippingUnitController : Controller
    {
        private readonly IShippingUnitRepository _shippingUnitRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ShippingUnitController(IShippingUnitRepository shippingUnitRepository, IHttpContextAccessor httpContextAccessor)
        {
            _shippingUnitRepository = shippingUnitRepository;
            _httpContextAccessor = httpContextAccessor;
        }
        // GET: ShippingUnitController
        public ActionResult Index()
        {
            ViewBag.DataView = _shippingUnitRepository.GetShippingUnit().Data;
            return View();
        }

        // GET: ShippingUnitController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShippingUnitController/Create
        [Route("add-shippingunit")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShippingUnitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-shippingunit")]
        public ActionResult Create(ShippingUnitModel model)
        {
            try
            {
                //Get role list
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = _shippingUnitRepository.Create(model, userActionId);
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

        // GET: ShippingUnitController/Edit/5
        [Route("edit-shippingunit")]
        public ActionResult Edit(int id)
        {
            var dataEdit = _shippingUnitRepository.Detail(id);
            return View(dataEdit);
        }

        // POST: ShippingUnitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-shippingunit")]
        public ActionResult Edit(ShippingUnitModel model)
        {
            try
            {
                //Get role list
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = _shippingUnitRepository.Update(model, userActionId);
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

        // GET: ShippingUnitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShippingUnitController/Delete/5
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
    }
}
