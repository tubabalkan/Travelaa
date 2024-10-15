using Microsoft.AspNetCore.Mvc;

namespace Travelaa.WebUI.ViewComponents.Default
{
    public class _ExploreTour : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
