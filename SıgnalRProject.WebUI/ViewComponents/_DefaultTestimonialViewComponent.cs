using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SıgnalRProject.WebUI.DTOs.TestimonialDto;

namespace SıgnalRProject.WebUI.ViewComponents
{
    public class _DefaultTestimonialViewComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DefaultTestimonialViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7024/api/Testimonial");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
            return View(values);
        }
    }
}
