using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using Travelaa.WebUI.Dtos;

namespace Travelaa.WebUI.Controllers
{
    public class StatistikControlle1 : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatistikControlle1(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/Category/CategoryCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.c = jsonData;
            return View();
        }
    }
}
