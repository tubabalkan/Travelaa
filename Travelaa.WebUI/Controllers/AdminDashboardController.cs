using Microsoft.AspNetCore.Mvc;

namespace Travelaa.WebUI.Controllers
{
    public class AdminDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
