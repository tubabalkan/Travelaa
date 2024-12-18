﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Travelaa.WebUI.Dtos.DestinationTemaDto;
using Travelaa.WebUI.Dtos.GaleriDto;

namespace Travelaa.WebUI.ViewComponents.Default
{
    public class _Gallery : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _Gallery(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
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
