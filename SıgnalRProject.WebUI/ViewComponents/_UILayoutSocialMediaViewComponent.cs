using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SıgnalRProject.WebUI.DTOs.SocialMediaDto;

namespace SıgnalRProject.WebUI.ViewComponents
{
    public class _UILayoutSocialMediaViewComponent : ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;
        public _UILayoutSocialMediaViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7024/api/SocialMedia");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSocialMediaDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

