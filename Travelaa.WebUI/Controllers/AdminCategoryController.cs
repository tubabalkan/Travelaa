using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Travelaa.WebUI.Dtos;

namespace Travelaa.WebUI.Controllers
{
    public class AdminCategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminCategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/Category");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResaultCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
