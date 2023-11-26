using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SıgnalRProject.WebUI.DTOs.DiscountDto;

namespace SıgnalRProject.WebUI.ViewComponents
{
    public class _DefaultOfferViewComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DefaultOfferViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7024/api/Discount/GetListByStatusTrue");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultDiscountDto>>(jsonData);
            return View(values);
        }
    }
}
