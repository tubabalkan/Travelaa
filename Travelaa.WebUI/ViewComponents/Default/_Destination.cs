using Microsoft.AspNetCore.Mvc;

namespace Travelaa.WebUI.ViewComponents.Default
{
    public class _Destination : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
