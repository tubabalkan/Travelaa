using Microsoft.AspNetCore.Mvc;

namespace Travelaa.WebUI.ViewComponents.Default
{
    public class _Contact : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
