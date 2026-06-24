using Commons.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.ViewModels;
using Newtonsoft.Json;
using Repositories.Interface;
using System.Security.Claims;

namespace WebSIMManager.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserController(IAccountRepository accountRepository, IRoleRepository roleRepository, IHttpContextAccessor httpContextAccessor)
        {
            _accountRepository = accountRepository;
            _roleRepository = roleRepository;
            _httpContextAccessor = httpContextAccessor;
        }
         
        // GET: UserController
        //[Authorize(Roles = "Xem danh sách nhân viên")]
        public ActionResult Index(GetPagingRequest request)
        {
            request.keyword = request.keyword == null ? "" : request.keyword;
            request.pageIndex = request.pageIndex == 0 ? 1 : request.pageIndex;
            request.pageSize = 10;

            var data = _accountRepository.GetAllPaging(request);
            if (data != null)
            {
                @ViewBag.UserData = data.Data;
                @ViewBag.Pager = data.Pager;
            }
            return View();
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        [Route("add-user")]
        [Authorize(Roles = "Tạo mới nhân viên")]
        public ActionResult Create()
        {
            //Get role list
            @ViewBag.GroupLst = _roleRepository.GetGroupListForCombo();

            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-user")]
        [Authorize(Roles = "Tạo mới nhân viên")]
        public ActionResult Create(UserCreateRequest userInfo)
        {
            try
            {
                //Get role list
                @ViewBag.GroupLst = _roleRepository.GetGroupListForCombo();
                if (!ModelState.IsValid)
                {
                    return View(userInfo);
                }

                var result = _accountRepository.Create(userInfo);
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return View(userInfo);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        [Route("edit-user")]
        //[Authorize(Roles = "Sửa nhân viên")]
        public ActionResult Edit(Guid id)
        {
            //Get role list
            @ViewBag.GroupLst = _roleRepository.GetGroupListForCombo();
            var userData = _accountRepository.GetUserForEdit(id);
            return View(userData);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-user")]
        //[Authorize(Roles = "Sửa nhân viên")]
        public ActionResult Edit(UserEditRequest userInfo)
        {
            try
            {
                @ViewBag.GroupLst = _roleRepository.GetGroupListForCombo();

				if (!ModelState.IsValid)
                {
                    return View(userInfo);
                }

                var result = _accountRepository.Update(userInfo);

                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return View(userInfo);
                }
            }
            catch
            {
                return View(userInfo);
            }
        }
        // GET: UserController/Edit/5
        [Route("profile")]
        public ActionResult Profile(int i)
        {
            //Get role list
            var id = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
            @ViewBag.RoleLst = _roleRepository.GetRoleListForCombo();
            var userData = _accountRepository.GetUserForEdit(id);
            return View(userData);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("profile")]
        public ActionResult Profile(UserEditRequest userInfo)
        {
            try
            {
                @ViewBag.RoleLst = _roleRepository.GetRoleListForCombo();
                if (!ModelState.IsValid)
                {
                    return View(userInfo);
                }

                var result = _accountRepository.Update(userInfo);

                if (result.Code == "1")
                {
                    return View(userInfo);
                }
                else
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return View(userInfo);
                }
            }
            catch
            {
                return View(userInfo);
            }
        }
        // GET: UserController/Edit/5
        [Route("doi-pass")]
        public ActionResult ChangePassword()
        {
            return View();
        }
        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("doi-pass")]
        public ActionResult ChangePassword(ChangePasswordRequest request)
        {
            try
            {
                @ViewBag.RoleLst = _roleRepository.GetRoleListForCombo();
                if (!ModelState.IsValid)
                {
                    return View(request);
                }
                request.id = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = _accountRepository.ChangePassword(request).Result;

                if (result.Code == "1")
                {
                    @ViewBag.Message = "Change password success.";
                    return View();
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
        [HttpGet]
        // POST: UserController/Delete/5
        [Authorize(Roles = "Xóa nhân viên")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = _accountRepository.Delete(id, userId);
                if (result.Code != "1")
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return Content("<script language='javascript' type='text/javascript'>alert('" + result.Message + "');</script>");
                }
                else
                    return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
