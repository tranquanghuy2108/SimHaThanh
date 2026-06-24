using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Requests;
using Models.ViewModels;
using Repositories.Interface;

namespace WebSIMManager.Controllers
{
    [Authorize]
    public class SIMNetworkController : BaseController
    {
        private readonly ISIMRepository _SIMRepository;
        public SIMNetworkController(ISIMRepository SIMRepository)
        {
            _SIMRepository = SIMRepository;
        }
        // GET: SIMTypeController
        [Authorize(Roles = "Xem nhà mạng")]
        public ActionResult Index(GetPagingRequest request)
        {
            if (request.keyword == null)
                request.keyword = "";
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageSize = 50;

            var data = _SIMRepository.GetSIMNetworkPaging(request);
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
        [Route("add-sim-network")]
        [Authorize(Roles = "Tạo mới nhà mạng")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIMTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-sim-network")]
        [Authorize(Roles = "Tạo mới nhà mạng")]
        public ActionResult Create(SIMNetworkCreateModel request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _SIMRepository.CreateSIMNetwork(request);
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
        [Route("edit-sim-network")]
        [Authorize(Roles = "Sửa nhà mạng")]
        public ActionResult Edit(int id)
        {
            var data = _SIMRepository.GetSIMNetwork(id);
            return View(data);
        }

        // POST: SIMTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-sim-network")]
        [Authorize(Roles = "Sửa nhà mạng")]
        public ActionResult Edit(SIMNetworkEditModel request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _SIMRepository.UpdateSIMNetwork(request);
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
        [Authorize(Roles = "Xóa nhà mạng")]
        public ActionResult Delete(int id)
        {
            try
            {
                var result = _SIMRepository.DeleteSIMNetwork(id);

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
