using Microsoft.AspNetCore.Mvc;

namespace Travelaa.WebUI.ViewComponents.Default
{
    public class _Script : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();


        }
    }
}
