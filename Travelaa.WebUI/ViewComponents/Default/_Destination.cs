using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Travelaa.WebUI.Dtos.DestinationTemaDto;

namespace Travelaa.WebUI.ViewComponents.Default
{
    public class _Destination : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _Destination(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult>  InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/Category");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultDestinationTemaDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
