using Microsoft.AspNetCore.Mvc;

namespace Travelaa.WebUI.ViewComponents.Default
{
    public class _Footer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();


        }
    }
}
