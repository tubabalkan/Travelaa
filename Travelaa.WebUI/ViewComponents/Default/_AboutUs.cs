﻿using Microsoft.AspNetCore.Mvc;

namespace Travelaa.WebUI.ViewComponents.Default
{
    public class _AboutUs : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
