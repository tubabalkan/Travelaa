using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using Travelaa.WebUI.Dtos;

namespace Travelaa.WebUI.Controllers
{
    public class AdminTurController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminTurController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/DestinationCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResaultDestinationDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> DeleteDestinationn(int id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.DeleteAsync("https://localhost:7113/api/Destination?id=" + id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateDestinationn(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/Destination/GetDestination?id=" + id);
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<UpdateDestinationDto>(jsonData);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateDestinationn(UpdateDestinationDto updateDestinationDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateDestinationDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PutAsync("https://localhost:7113/api/Destination", stringContent);
            return RedirectToAction("Index");
        }
    }
}
