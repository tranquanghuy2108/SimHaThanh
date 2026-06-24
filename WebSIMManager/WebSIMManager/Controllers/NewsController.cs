using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Requests;
using Models.ViewModels;
using Repositories.Interface;

namespace WebSIMManager.Controllers
{
    [Authorize]
    public class NewsController : Controller
    {
        private readonly INewsRepository _newsRepository;
        public NewsController(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }
        // GET: NewsController
        public ActionResult Index(GetPagingRequest request)
        {
            if (request.keyword == null)
                request.keyword = "";
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageSize = 50;
            var data = _newsRepository.GetNewPaging(request);
            if (data != null)
            {
                @ViewBag.DataView = data.Data;
                @ViewBag.Pager = data.Pager;
            }
            return View();
        }

        // GET: NewsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewsController/Create
        [Route("add-news")]
        public ActionResult Create()
        {
            @ViewBag.Category = _newsRepository.GetCategoryListForCombo();
            return View();
        }

        // POST: NewsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-news")]
        public ActionResult Create(NewsEditModel request)
        {
            try
            {
                @ViewBag.Category = _newsRepository.GetCategoryListForCombo();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _newsRepository.CreateNew(request);
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

        // GET: NewsController/Edit/5
        [Route("edit-news")]
        public ActionResult Edit(int id)
        {
            @ViewBag.Category = _newsRepository.GetCategoryListForCombo();
            var data = _newsRepository.GetNewDetail(id);
            return View(data);
        }

        // POST: NewsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-news")]
        public ActionResult Edit(NewsEditModel request)
        {
            try
            {
                @ViewBag.Category = _newsRepository.GetCategoryListForCombo();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _newsRepository.UpdateNew(request);
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

        // GET: NewsController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var result = _newsRepository.DeleteNew(id);

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
