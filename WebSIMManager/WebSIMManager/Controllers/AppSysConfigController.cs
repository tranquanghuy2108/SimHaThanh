using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;
using Repositories.Interface;
using System.Security.Claims;

namespace WebSIMManager.Controllers
{
    public class AppSysConfigController : Controller
    {
        private readonly ISystemConfigRepository _systemConfigRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AppSysConfigController(ISystemConfigRepository systemConfigRepository, IHttpContextAccessor httpContextAccessor)
        {
            _systemConfigRepository = systemConfigRepository;
            _httpContextAccessor = httpContextAccessor;
        }
        // GET: AppSysConfigController/Edit/5
        [Route("app-config")]
        public ActionResult Index()
        {
            var dataConfig = _systemConfigRepository.GetAppSysConfig();
            return View(dataConfig);
        }

        // POST: AppSysConfigController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("app-config")]
        public ActionResult Index(AppSysConfigModel model)
        {
            try
            {
                //Get role list
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var userActionId = new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = _systemConfigRepository.UpdateAppSysConfig(model, userActionId);
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
    }
}
