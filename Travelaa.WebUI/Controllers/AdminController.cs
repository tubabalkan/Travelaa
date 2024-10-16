using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using Travelaa.WebUI.Dtos;

namespace Travelaa.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/Admin");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResaultAdminDto>>(jsonData);
                return View(values);
            }
            return View();
           
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAdmin(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/Admin?id=" + id);
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<UpdateAdminDto>(jsonData);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAdmin(UpdateAdminDto updateAdminDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateAdminDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PutAsync("https://localhost:7113/api/Admin", stringContent);
            return RedirectToAction("Index");
        }
    }
}
