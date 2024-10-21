using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Travelaa.WebUI.Dtos;
using Travelaa.WebUI.Dtos.GaleriDto;

namespace Travelaa.WebUI.Controllers
{
    public class AdminGaleriController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminGaleriController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/Galeri");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultGaleriDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
