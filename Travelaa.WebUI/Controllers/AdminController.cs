using Microsoft.AspNetCore.Mvc;

namespace Travelaa.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
