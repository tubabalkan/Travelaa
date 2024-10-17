using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Travelaa.WebUI.Dtos;

namespace Travelaa.WebUI.ViewComponents.Dashboard
{
    public class _DashboardTur:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardTur(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/Destination/LastEightDestination");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<DestinationEightLast>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
