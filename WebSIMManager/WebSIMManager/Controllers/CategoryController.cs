using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Requests;
using Models.ViewModels;
using Repositories.Interface;

namespace WebSIMManager.Controllers
{
    public class CategoryController : Controller
    {
        private readonly INewsRepository _newsRepository;
        public CategoryController(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }
        // GET: CategoryController
        public ActionResult Index(GetPagingRequest request)
        {
            if (request.keyword == null)
                request.keyword = "";
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageSize = 50;
            var data = _newsRepository.GetCategoryPaging(request);
            if (data != null)
            {
                @ViewBag.DataView = data.Data;
                @ViewBag.Pager = data.Pager;
            }
            return View();
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        [Route("add-category")]
        public ActionResult Create()
        {
            @ViewBag.Category = _newsRepository.GetCategoryListForCombo();
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-category")]
        public ActionResult Create(CategoryEditModel request)
        {
            try
            {
                @ViewBag.Category = _newsRepository.GetCategoryListForCombo();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _newsRepository.CreateCategory(request);
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

        // GET: CategoryController/Edit/5
        [Route("edit-category")]
        public ActionResult Edit(int id)
        {
            @ViewBag.Category = _newsRepository.GetCategoryListForCombo();
            var data = _newsRepository.GetCategory(id);
            return View(data);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-category")]
        public ActionResult Edit(CategoryEditModel request)
        {
            try
            {
                @ViewBag.Category = _newsRepository.GetCategoryListForCombo();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _newsRepository.UpdateCategory(request);
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

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var result = _newsRepository.DeleteCategory(id);

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
