using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SıgnalRProject.Dto.SliderDto;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;

namespace SıgnalRProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;
        public SliderController(ISliderService sliderService, IMapper mapper)
        {
            _sliderService = sliderService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task< IActionResult> SliderList()
        {
            var sliders= await _sliderService.GetAllAsync();
            var value = _mapper.Map<List<ResultSliderDto>>(sliders);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSlider(CreateSliderDto createSliderDto)
        {
            var map = _mapper.Map<Slider>(createSliderDto);
            await _sliderService.AddAsync(map);
            return Ok("Öne Çıkan Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSlider(int id)
        {
            var value =await _sliderService.GetByIDAsync(id);
            await _sliderService.DeleteAsync(value);
            return Ok("Öne Çıkan Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSlider(int id)
        {
            var value = await _sliderService.GetByIDAsync(id);
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            var map = _mapper.Map<Slider>(updateSliderDto);
            await _sliderService.UpdateAsync(map);
            return Ok("Öne Çıkan Alan Bilgisi Güncellendi");
        }
    }
}

