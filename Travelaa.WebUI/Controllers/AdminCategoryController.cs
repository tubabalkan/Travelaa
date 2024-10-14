using Microsoft.AspNetCore.Mvc;

namespace Travelaa.WebUI.Controllers
{
    public class AdminCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
