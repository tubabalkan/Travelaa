using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using Travelaa.WebUI.Dtos.ContactDto;

namespace Travelaa.WebUI.ViewComponents.Default
{
    public class _Contact : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _Contact(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
       

    }
}
