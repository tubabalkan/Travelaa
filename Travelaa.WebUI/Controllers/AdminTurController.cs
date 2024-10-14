using Microsoft.AspNetCore.Mvc;

namespace Travelaa.WebUI.Controllers
{
    public class AdminTurController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
