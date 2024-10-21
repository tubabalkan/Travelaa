using Microsoft.AspNetCore.Mvc;

namespace Travelaa.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

