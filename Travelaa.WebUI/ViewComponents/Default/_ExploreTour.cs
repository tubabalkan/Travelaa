using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Travelaa.WebUI.Dtos;
using Travelaa.WebUI.Dtos.TurTemaDto;

namespace Travelaa.WebUI.ViewComponents.Default
{
    public class _ExploreTour : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ExploreTour(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/Destination");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTurTemaDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
