using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SıgnalRProject.Dto.SocialMediaDto;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;

namespace SıgnalRProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;
        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> SocialMediaList()
        {
            var socialMedias = await _socialMediaService.GetAllAsync();
            var value = _mapper.Map<List<ResultSocialMediaDto>>(socialMedias);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            var value = _mapper.Map<SocialMedia>(createSocialMediaDto);
            await _socialMediaService.AddAsync(value);
            return Ok("Sosyal Medya Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSocialMedia(int id)
        {
            var value = await _socialMediaService.GetByIDAsync(id);
            await _socialMediaService.DeleteAsync(value);
            return Ok("Sosyal Medya Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSocialMedia(int id)
        {
            var value = await _socialMediaService.GetByIDAsync(id);
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var value = _mapper.Map<SocialMedia>(updateSocialMediaDto);
            await _socialMediaService.AddAsync(value);
            return Ok("Sosyal Medya Bilgisi Güncellendi");
        }
    }
}
