using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SıgnalRProject.Dto.DiscountDto;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;

namespace SıgnalRProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;
        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> DiscountList()
        {
            var discounts = await _discountService.GetAllAsync();
            var value = _mapper.Map<List<ResultDiscountDto>>(discounts);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            var map = _mapper.Map<Discount>(createDiscountDto);
            await _discountService.AddAsync(map);
            return Ok("İndirim Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiscount(int id)
        {
            var value = await _discountService.GetByIDAsync(id);
            await _discountService.DeleteAsync(value);
            return Ok("İndirim Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscount(int id)
        {
            var value = await _discountService.GetByIDAsync(id);
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            var map = _mapper.Map<Discount>(updateDiscountDto);
            await _discountService.UpdateAsync(map);
            return Ok("İndirim Bilgisi Güncellendi");
        }
        [HttpGet("ChangeStatusToTrue/{id}")]
        public async Task<IActionResult> ChangeStatusToTrue(int id)
        {
            await _discountService.ChangeStatusToTrue(id);
            return Ok("Ürün İndirimi Aktif Hale Getirildi");
        }

        [HttpGet("ChangeStatusToFalse/{id}")]
        public async Task<IActionResult> ChangeStatusToFalse(int id)
        {
           await _discountService.ChangeStatusToFalse(id);
            return Ok("Ürün İndirimi Pasif Hale Getirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrue()
        {
            var discounts = await _discountService.GetListByStatusTrue();
            var value = _mapper.Map<List<ResultDiscountDto>>(discounts);
            return Ok(value);
        }
    }
}
