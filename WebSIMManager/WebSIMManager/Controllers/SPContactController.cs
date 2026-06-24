using Commons.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.ViewModels;
using Repositories.Implement;
using Repositories.Interface;

namespace WebSIMManager.Controllers
{
    public class SPContactController : BaseController
    {
        private readonly IContactRepository _contactRepository;
        public SPContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        // GET: SPContactController
        [Authorize(Roles = "Xem danh sách kênh bán hàng")]
        public ActionResult Index(GetPagingRequest request)
        {
            if (request.keyword == null)
                request.keyword = "";
            if (request.pageIndex == 0)
                request.pageIndex = 1;
            request.pageSize = 50;
            var data = _contactRepository.GetSPContactPaging(request);
            if (data != null)
            {
                @ViewBag.DataView = data.Data;
                @ViewBag.Pager = data.Pager;
            }
            return View();
        }
        // GET: SPContactController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SPContactController/Create
        [Route("add-spcontact")]
        [Authorize(Roles = "Tạo mới kênh bán hàng")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: SPContactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-spcontact")]
        [Authorize(Roles = "Tạo mới kênh bán hàng")]
        public ActionResult Create(SPContactCreateModel request)
        {
            try
            {                
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _contactRepository.CreateSPContact(request);
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

        // GET: SPContactController/Edit/5
        [Route("edit-spcontact")]
        [Authorize(Roles = "Sửa kênh bán hàng")]
        public ActionResult Edit(int id)
        {
            var data= _contactRepository.GetSPContactDetail(id);
            return View(data);
        }

        // POST: SPContactController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-spcontact")]
        [Authorize(Roles = "Sửa kênh bán hàng")]
        public ActionResult Edit(SPContactEditModel request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _contactRepository.UpdateSPContact(request);
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

        // GET: SPContactController/Delete/5
        [Authorize(Roles = "Xóa kênh bán hàng")]
        public ActionResult Delete(int id)
        {
            try
            {
                var result = _contactRepository.DeleteSPContact(id);

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
