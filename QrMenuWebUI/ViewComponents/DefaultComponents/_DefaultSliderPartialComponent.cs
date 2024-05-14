﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QrMenuWebUI.Dtos.SliderDtos;

namespace QrMenuWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultSliderPartialComponent: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultSliderPartialComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7012/api/Sliders");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultSliderDto>>(jsonData);
            return View(values);
        }
    }
}
