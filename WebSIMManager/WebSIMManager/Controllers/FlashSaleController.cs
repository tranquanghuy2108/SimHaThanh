using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Requests;
using Models.ViewModels;
using Repositories.Implement;
using Repositories.Interface;
using System.Security.Claims;

namespace WebSIMManager.Controllers
{
    public class FlashSaleController : Controller
    {
        private readonly IAppContentRepository _appContentRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public FlashSaleController(IAppContentRepository appContentRepository, IHttpContextAccessor httpContextAccessor)
        {
            _appContentRepository = appContentRepository;
            _httpContextAccessor = httpContextAccessor;
        }
        // GET: BankController
        //[Authorize(Roles = "Xem danh sách tk bank")]
        public ActionResult Index(GetPagingRequest request)
        {
            if (request.keyword == null)
                request.keyword = "";
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageSize = 50;
            var data = _appContentRepository.GetFlashSalePaging(request);
            if (data != null)
            {
                @ViewBag.DataView = data.Data;
                @ViewBag.Pager = data.Pager;
            }
            return View();
        }

        [Route("add-flashsale")]
        // GET: AuctionController/Create
        public ActionResult Create()
        {
            var simOnFlashSale = _appContentRepository.GetSimForFlashSale();
            FlashSaleModel model = new FlashSaleModel();
            model.StartTime = DateTime.Now;
            model.EndTime = DateTime.Now;
            model.SimFlashSaleInfos = new();
            model.SimFlashSaleInfos = simOnFlashSale;
            return View(model);
        }

        // POST: AuctionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-flashsale")]
        public ActionResult Create(FlashSaleModel model)
        {
            try
            {
                //Get role list
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var userActionId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = _appContentRepository.CreateFlashSale(model, userActionId);
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

        [Route("edit-flashsale")]
        // GET: AuctionController/Edit/5
        public ActionResult Edit(int id)
        {
            var dataEdit = _appContentRepository.GetFlashSaleDetail(id);
            return View(dataEdit);
        }

        // POST: AuctionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-flashsale")]
        public ActionResult Edit(FlashSaleModel model)
        {
            try
            {
                //Get role list
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var userActionId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = _appContentRepository.UpdateFlashSale(model, userActionId);
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

        // GET: AuctionController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var userActionId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = _appContentRepository.DeleteFlashSale(id, userActionId);

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
