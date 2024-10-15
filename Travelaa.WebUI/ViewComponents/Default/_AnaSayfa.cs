using Microsoft.AspNetCore.Mvc;

namespace Travelaa.WebUI.ViewComponents.Default
{
    public class _AnaSayfa : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
