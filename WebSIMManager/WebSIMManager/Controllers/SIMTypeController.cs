using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Models.Requests;
using Models.ViewModels;
using Repositories.Implement;
using Repositories.Interface;

namespace WebSIMManager.Controllers
{
    [Authorize]
    public class SIMTypeController : BaseController
    {
        private readonly ISIMRepository _SIMRepository;
        public SIMTypeController(ISIMRepository SIMRepository)
        {
            _SIMRepository = SIMRepository;
        }
        // GET: SIMTypeController
        [Authorize(Roles = "Xem số đẹp")]
        public ActionResult Index(GetPagingRequest request)
        {
            if (request.keyword == null)
                request.keyword = "";
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageSize = 50;

            var data = _SIMRepository.GetTypeOfSIMPaging(request);
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
        [Route("add-sim-type")]
        [Authorize(Roles = "Tạo mới số đẹp")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIMTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-sim-type")]
        [Authorize(Roles = "Tạo mới số đẹp")]
        public ActionResult Create(TypeOfSimCreateModel request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _SIMRepository.CreateTypeOfSIM(request);
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
        [Route("edit-sim-type")]
        [Authorize(Roles = "Sửa số đẹp")]
        public ActionResult Edit(int id)
        {
            var data = _SIMRepository.GetTypeOfSim(id);
            return View(data);
        }

        // POST: SIMTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-sim-type")]
        [Authorize(Roles = "Sửa số đẹp")]
        public ActionResult Edit(TypeOfSimEditModel request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _SIMRepository.UpdateTypeOfSim(request);
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
        [Authorize(Roles = "Xóa số đẹp")]
        public ActionResult Delete(int id)
        {
            try
            {
                var result = _SIMRepository.DeleteSIMType(id);

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
