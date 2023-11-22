using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

using SıgnalRProject.WebUI.DTOs.ContactDto;

namespace SıgnalRProject.WebUI.ViewComponents
{
    public class _UILayoutFooterViewComponent: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _UILayoutFooterViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7024/api/Contact");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
            return View(values);
        }
    }
}
