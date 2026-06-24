using Microsoft.AspNetCore.Mvc;

namespace WebSIMManager.Controllers
{
    public class SYSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BackupDB()
        {
            return View();
        }
    }
}
