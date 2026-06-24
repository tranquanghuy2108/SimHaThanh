using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Requests;
using Models.ViewModels;
using Repositories.Interface;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebSIMManager.Controllers
{
    [Authorize]
    public class RoleController : BaseController
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public RoleController(IAccountRepository accountRepository, IRoleRepository roleRepository, IHttpContextAccessor httpContextAccessor)
        {
            _accountRepository = accountRepository;
            _roleRepository = roleRepository;
            _httpContextAccessor = httpContextAccessor;
        }
        // GET: RoleController
        //[Authorize(Roles = "Xem danh sách nhóm phân quyền")]
        public ActionResult Index(GetPagingRequest request)
        {
            request.keyword = request.keyword == null ? "" : request.keyword;
            request.pageIndex = request.pageIndex == 0 ? 1 : request.pageIndex;
            request.pageSize = 10;
            var dataView = _roleRepository.GetRoleGroupPaging(request);
            if (dataView != null)
            {
                @ViewBag.Data = dataView.Data;
                @ViewBag.Pager = dataView.Pager;
            }
            return View();
        }

        // GET: RoleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoleController/Create
        [Route("add-role")]
        public ActionResult CreateRole()
        {
            ViewBag.DataRoles = _roleRepository.GetRolePaging().Data;
            return View();
        }

        // POST: RoleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-role")]
        public ActionResult CreateRole(RoleCreate request)
        {
            try
            {
                ViewBag.DataRoles = _roleRepository.GetRolePaging();
                //Get role list
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _roleRepository.CreateRole(request);
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(CreateRole));
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }        // GET: RoleController/Create
        [Route("edit-role")]
        public ActionResult EditRole(Guid Id)
        {
            var role = _roleRepository.GetRoleById(Id);
            ViewBag.DataRoles = _roleRepository.GetRolePaging().Data;
            return View(role);
        }

        // POST: RoleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-role")]
        public ActionResult EditRole(RoleCreate request)
        {
            try
            {
                ViewBag.DataRoles = _roleRepository.GetRolePaging();
                //Get role list
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _roleRepository.UpdateRole(request);
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(CreateRole));
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }
        // GET: RoleController/Create
        [Route("add-group")]
        //[Authorize(Roles = "Tạo mới nhóm phân quyền")]
        public ActionResult CreateGroup()
        {
            ViewBag.ListRoles = _roleRepository.GetRoleListForCombo();
            return View();
        }

        // POST: RoleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-group")]
        //[Authorize(Roles = "Tạo mới nhóm phân quyền")]
        public ActionResult CreateGroup(AppGroupCreate request)
        {
            ViewBag.ListRoles = _roleRepository.GetRoleListForCombo();

            try
            {
                //Get role list
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _roleRepository.CreateGroup(request);
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: RoleController/Create
        [Route("edit-group")]
        //[Authorize(Roles = "Sửa nhóm phân quyền")]
        public ActionResult EditGroup(int id)
        {
            var data = _roleRepository.GetGroupById(id);
            ViewBag.ListRoles = _roleRepository.GetRoleListForCombo();
            return View(data);
        }

        // POST: RoleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-group")]
        //[Authorize(Roles = "Sửa nhóm phân quyền")]
        public ActionResult EditGroup(AppGroupCreate request)
        {
            ViewBag.ListRoles = _roleRepository.GetRoleListForCombo();

            try
            {
                //Get role list
                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                var result = _roleRepository.UpdateGroup(request);
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(System.String.Empty, result.Message);
                    return View(request);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: RoleController/Delete/5
        public ActionResult DeleteRole(Guid id)
        {
            try
            {
                var result = _roleRepository.DeleteRole(id);

                if (result.Code == "1")
                {
                    ModelState.AddModelError(string.Empty, result.Message);
                }
                return RedirectToAction(nameof(CreateRole));
            }
            catch
            {
                return RedirectToAction(nameof(CreateRole));
            }
        }
        // GET: RoleController/Delete/5
        [Authorize(Roles = "Xóa nhóm phân quyền")]
        public ActionResult DeleteGroup(int id)
        {
            try
            {
                var result = _roleRepository.DeleteGroup(id);

                if (result.Code == "1")
                {
                    ModelState.AddModelError(string.Empty, result.Message);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

    }
}
