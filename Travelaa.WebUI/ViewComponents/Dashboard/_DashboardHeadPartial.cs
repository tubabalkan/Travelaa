using Microsoft.AspNetCore.Mvc;

namespace Travelaa.WebUI.ViewComponents.Dashboard
{
    public class _DashboardHeadPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardHeadPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/DashboardIstatistik/CategoryCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.CategoryCount = jsonData;

            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:7113/api/DashboardIstatistik/AdminCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.AdminCount = jsonData1;

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:7113/api/DashboardIstatistik/ContactCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.ContactCount = jsonData2;


            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:7113/api/DashboardIstatistik/DestinationCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.DestinationCount = jsonData3;
            return View();
        }
    }
}
