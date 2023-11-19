using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SıgnalRProject.Dto.SocialMediaDto;
using SıgnalRProject.Dto.TestimonialDto;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;

namespace SıgnalRProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;
        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            var testimonials = await _testimonialService.GetAllAsync();
            var value = _mapper.Map<List<ResultTestimonialDto>>(testimonials);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(createTestimonialDto);
            await _testimonialService.UpdateAsync(value);
            return Ok("Müşteri Yorum Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            var value = await _testimonialService.GetByIDAsync(id);
            await _testimonialService.DeleteAsync(value);
            return Ok("Müşteri Yorum Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial(int id)
        {
            var value = await _testimonialService.GetByIDAsync(id);
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(updateTestimonialDto);
            await _testimonialService.UpdateAsync(value);
            return Ok("Müşteri Yorum Bilgisi Güncellendi");
        }
    }
}
