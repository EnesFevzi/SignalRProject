using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SıgnalRProject.Dto.BasketDto;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;

namespace SıgnalRProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly IMapper _mapper;

        public BasketController(IBasketService basketService, IMapper mapper)
        {
            _basketService = basketService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetBasketByMenuTableID(int id)
        {
            var values = _basketService.GetBasketByMenuTableNumber(id);
            return Ok(values);
        }
        [HttpGet("BasketListByMenuTableWithProductName")]
        public async Task<IActionResult> BasketListByMenuTableWithProductName(int id)
        {
            var values = await _basketService.BasketListByMenuTableWithProductName(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            ////Bahçe 01 --> 45
            //using var context = new SignalRContext();
            //_basketService.TAdd(new Basket()
            //{
            //    ProductID = createBasketDto.ProductID,
            //    Count = 1,
            //    MenuTableID = 4,
            //    Price = context.Products.Where(x => x.ProductID == createBasketDto.ProductID).Select(y => y.Price).FirstOrDefault(),
            //    TotalPrice = 0
            //});
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBasket(int id)
        {
            var value = await _basketService.GetByIDAsync(id);
            await _basketService.DeleteAsync(value);
            return Ok("Sepetteki Seçilen Ürün Silindi");
        }
    }
}
