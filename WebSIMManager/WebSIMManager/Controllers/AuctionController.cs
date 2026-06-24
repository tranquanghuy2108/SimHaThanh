using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Requests;
using Models.ViewModels;
using Repositories.Implement;
using Repositories.Interface;
using System.Security.Claims;

namespace WebSIMManager.Controllers
{
    public class AuctionController : Controller
    {
        private readonly IAuctionRepository _auctionRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AuctionController(IAuctionRepository auctionRepository, IHttpContextAccessor httpContextAccessor)
        {
            _auctionRepository = auctionRepository;
            _httpContextAccessor = httpContextAccessor;
        }
        // GET: AuctionController
        public ActionResult Index(GetPagingRequest request)
        {
            if (request.keyword == null)
                request.keyword = "";
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageSize = 50;
            var data = _auctionRepository.GetAuction(request);
            if (data != null)
            {
                @ViewBag.DataView = data.Data;
                @ViewBag.Pager = data.Pager;
            }
            return View();
        }

        [Route("add-auction")]
        // GET: AuctionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuctionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-auction")]
        public ActionResult Create(AuctionModel model)
        {
            try
            {
                //Get role list
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = _auctionRepository.CreateAuction(model, userActionId);
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

        [Route("edit-auction")]
        // GET: AuctionController/Edit/5
        public ActionResult Edit(int id)
        {
            var dataEdit = _auctionRepository.DetailAuction(id);
            return View(dataEdit);
        }

        // POST: AuctionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-auction")]
        public ActionResult Edit(AuctionModel model)
        {
            try
            {
                //Get role list
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = _auctionRepository.UpdateAuction(model, userActionId);
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
                var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = _auctionRepository.DeleteAuction(id, userActionId);

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
