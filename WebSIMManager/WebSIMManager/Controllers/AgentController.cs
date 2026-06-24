using DocumentFormat.OpenXml.Office2016.Excel;
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
    public class AgentController : BaseController
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICollaboratorsGroupRepository _collaboratorsGroupRepository;
        private readonly ISIMRepository _simRepository;
        public AgentController(IAccountRepository accountRepository, IRoleRepository roleRepository, IHttpContextAccessor httpContextAccessor, ICollaboratorsGroupRepository collaboratorsGroupRepository, ISIMRepository simRepository)
        {
            _accountRepository = accountRepository;
            _roleRepository = roleRepository;
            _httpContextAccessor = httpContextAccessor;
            _collaboratorsGroupRepository = collaboratorsGroupRepository;
            _simRepository = simRepository;
        }
        #region Agent
        // GET: UserController
        [Authorize(Roles = "Xem danh sách đại lý")]
        public ActionResult Index()
        {
            @ViewBag.AgentGroups = _collaboratorsGroupRepository.GetAgentGroupsForCombo();
            return View();
        }

        [Route("khach-le")]
        [Authorize(Roles = "Xem danh sách đại lý")]
        public ActionResult Customer()
        {
            //@ViewBag.AgentGroups = _collaboratorsGroupRepository.GetAgentGroupsForCombo();
            return View();
        }

        [Route("dai-ly-ki-gui")]
        public ActionResult ConsignmentAgent()
        {
            @ViewBag.AgentGroups = _collaboratorsGroupRepository.GetAgentGroupsForCombo();
            return View();
        }

        public ActionResult Search([FromBody] AgentFilterRequest request)
        {
            request.pageIndex = request.pageIndex == 0 ? 1 : request.pageIndex;
            request.pageSize = 10;

            var data = _accountRepository.GetAgentList(request);
            return Json(data);
        }
        public ActionResult SearchCustomer([FromBody] AgentFilterRequest request)
        {
            request.pageIndex = request.pageIndex == 0 ? 1 : request.pageIndex;
            request.pageSize = 10;

            var data = _accountRepository.GetCustomerLst(request);
            return Json(data);
        }

        public ActionResult SearchConsignmentAgentLst([FromBody] AgentFilterRequest request)
        {
            request.pageIndex = request.pageIndex == 0 ? 1 : request.pageIndex;
            request.pageSize = 10;

            var data = _accountRepository.GetConsignmentAgentLst(request);
            return Json(data);
        }
        // GET: UserController/Create
        [Route("add-agent")]
        [Authorize(Roles = "Tạo mới KH/Đại lý")]
        public ActionResult Create()
        {
            //Get role list
            @ViewBag.AgentGroups = _collaboratorsGroupRepository.GetAgentGroupsForCombo();
            @ViewBag.DiscountForSimSellers = _collaboratorsGroupRepository.GetAgentGroupsForCombo(true);
            @ViewBag.RoleGroups = _roleRepository.GetGroupListForCombo(isStaffRole: false);
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-agent")]
        [Authorize(Roles = "Tạo mới KH/Đại lý")]
        public ActionResult Create(UserCreateRequest userInfo)
        {
            try
            {
                //Get role list
                @ViewBag.AgentGroups = _collaboratorsGroupRepository.GetAgentGroupsForCombo();
                @ViewBag.DiscountForSimSellers = _collaboratorsGroupRepository.GetAgentGroupsForCombo(true);
                @ViewBag.RoleGroups = _roleRepository.GetGroupListForCombo(isStaffRole: false);
                if (!ModelState.IsValid)
                {
                    return View(userInfo);
                }

                var result = _accountRepository.Create(userInfo, false);
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
        [Route("edit-agent")]
        [Authorize(Roles = "Sửa KH/Đại lý")]
        public ActionResult Edit(Guid id)
        {
            //Get role list
            @ViewBag.AgentGroups = _collaboratorsGroupRepository.GetAgentGroupsForCombo();
            @ViewBag.DiscountForSimSellers = _collaboratorsGroupRepository.GetAgentGroupsForCombo(true);
            @ViewBag.RoleGroups = _roleRepository.GetGroupListForCombo(isStaffRole: false);
            var userData = _accountRepository.GetUserForEdit(id);
            return View(userData);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-agent")]
        [Authorize(Roles = "Sửa KH/Đại lý")]
        public ActionResult Edit(UserEditRequest userInfo)
        {
            try
            {
                @ViewBag.AgentGroups = _collaboratorsGroupRepository.GetAgentGroupsForCombo();
                @ViewBag.DiscountForSimSellers = _collaboratorsGroupRepository.GetAgentGroupsForCombo(true);
                @ViewBag.RoleGroups = _roleRepository.GetGroupListForCombo(isStaffRole: false);
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
        [HttpGet]
        // POST: UserController/Delete/5
        [Authorize(Roles = "Xóa KH/Đại lý")]
        public ActionResult Delete(Guid id)
        {
            var userActionId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = _accountRepository.Delete(id, userActionId);
            return Json(result);
        }
        [HttpGet]
        // POST: UserController/Delete/5
        [Authorize(Roles = "Xóa sim của đại lý")]
        public ActionResult DeleteSIMOfAgent(Guid id)
        {
            var userActionId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = _simRepository.DeleteSimOfAgent(id, userActionId);
            return Json(result);
        }
        #endregion

        #region AgentGroup
        [Route("agent-group")]
        [Authorize(Roles = "Xem danh sách nhóm KH/Đại lý")]
        public ActionResult AgentGroup(GetPagingRequest request)
        {
            request.keyword = request.keyword == null ? "" : request.keyword;
            request.pageIndex = request.pageIndex == 0 ? 1 : request.pageIndex;
            request.pageSize = 10;

            var data = _collaboratorsGroupRepository.GetAgentGroup(request);
            if (data != null)
            {
                @ViewBag.DataView = data.Data;
                @ViewBag.Pager = data.Pager;
            }
            return View();
        }
        // GET: UserController/Create
        [Route("add-agent-group")]
        [Authorize(Roles = "Tạo mới nhóm KH/Đại lý")]
        public ActionResult AgentGroupCreate()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("add-agent-group")]
        [Authorize(Roles = "Tạo mới nhóm KH/Đại lý")]
        public ActionResult AgentGroupCreate(CollaboratorsGroupEditModels models)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(models);
                }

                models.IsApp = false;
                var result = _collaboratorsGroupRepository.Create(models);
                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(AgentGroup));
                }
                else
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return View(models);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        [Route("edit-agent-group")]
        [Authorize(Roles = "Sửa nhóm KH/Đại lý")]
        public ActionResult AgentGroupEdit(int id)
        {
            var editData = _collaboratorsGroupRepository.GetGroupById(id);
            return View(editData);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit-agent-group")]
        [Authorize(Roles = "Sửa nhóm KH/Đại lý")]
        public ActionResult AgentGroupEdit(CollaboratorsGroupEditModels models)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(models);
                }
                models.IsApp = false;
                var result = _collaboratorsGroupRepository.Edit(models);

                if (result.Code == "1")
                {
                    return RedirectToAction(nameof(AgentGroup));
                }
                else
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return View(models);
                }
            }
            catch
            {
                return View(models);
            }
        }
        [HttpGet]
        // POST: UserController/Delete/5
        [Authorize(Roles = "Xóa nhóm KH/Đại lý")]
        public ActionResult AgentGroupDelete(int id)
        {
            try
            {
                var result = _collaboratorsGroupRepository.Delete(id);
                if (result.Code != "1")
                {
                    ModelState.AddModelError(String.Empty, result.Message);
                    return Content("<script language='javascript' type='text/javascript'>alert('" + result.Message + "');</script>");
                }
                else
                    return RedirectToAction(nameof(AgentGroup));
            }
            catch
            {
                return RedirectToAction(nameof(AgentGroup));
            }
        }
        #endregion

    }
}
