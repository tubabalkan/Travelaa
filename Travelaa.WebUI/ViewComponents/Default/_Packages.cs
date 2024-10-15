using Microsoft.AspNetCore.Mvc;

namespace Travelaa.WebUI.ViewComponents.Default
{
    public class _Packages : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
