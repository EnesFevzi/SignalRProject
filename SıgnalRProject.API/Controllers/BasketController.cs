using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SıgnalRProject.DataAccess.Context;
using SıgnalRProject.DataAccess.UnıtOfWorks;
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
        private readonly IUnıtOfWork unıtOfWork;

        private readonly SıgnalRContext _context;
        private readonly IMapper _mapper;

        public BasketController(IBasketService basketService, IUnıtOfWork unıtOfWork, SıgnalRContext context, IMapper mapper)
        {
            _basketService = basketService;
            this.unıtOfWork = unıtOfWork;
            _context = context;
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
        public async Task< IActionResult> CreateBasket(CreateBasketDto createBasketDto)
        {
            Basket basket= new Basket()
            {
                ProductID = createBasketDto.ProductID,
                Count = 1,
                MenuTableID = 3,
                Price = _context.Products.Where(x => x.ProductID == createBasketDto.ProductID).Select(y => y.Price).FirstOrDefault(),
                TotalPrice = 0
            };
            await _basketService.AddAsync(basket);
           // await _basketService.AddAsync(basket);
            return Ok(basket);
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
