using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SıgnalRProject.DataAccess.Context;
using SıgnalRProject.Dto.ProductDto;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;

namespace SıgnalRProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var products = _productService.GetAllAsync();
            var value = _mapper.Map<List<ResultProductDto>>(products);
            return Ok(value);
        }

        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_productService.ProductCount());
        }

        [HttpGet("TotalPriceByDrinkCategory")]
        public IActionResult TotalPriceByDrinkCategory()
        {
            return Ok(_productService.TotalPriceByDrinkCategory());
        }

        [HttpGet("TotalPriceBySaladCategory")]
        public IActionResult TotalPriceBySaladCategory()
        {
            return Ok(_productService.TotalPriceBySaladCategory());
        }

        [HttpGet("ProductNameByMaxPrice")]
        public IActionResult ProductNameByMaxPrice()
        {
            return Ok(_productService.ProductNameByMaxPrice());
        }

        [HttpGet("ProductNameByMinPrice")]
        public IActionResult ProductNameByMinPrice()
        {
            return Ok(_productService.ProductNameByMinPrice());
        }

        [HttpGet("ProductAvgPriceByHamburger")]
        public IActionResult ProductAvgPriceByHamburger()
        {
            return Ok(_productService.ProductAvgPriceByHamburger());
        }

        [HttpGet("ProductCountByHamburger")]
        public IActionResult ProductCountByHamburger()
        {
            return Ok(_productService.ProductCountByCategoryNameHamburger());
        }

        [HttpGet("ProductCountByDrink")]
        public IActionResult ProductCountByDrink()
        {
            return Ok(_productService.ProductCountByCategoryNameDrink());
        }

        [HttpGet("ProductPriceAvg")]
        public IActionResult ProductPriceAvg()
        {
            return Ok(_productService.ProductPriceAvg());
        }

        [HttpGet("ProductPriceBySteakBurger")]
        public IActionResult ProductPriceBySteakBurger()
        {
            return Ok(_productService.ProductPriceBySteakBurger());
        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var products = _productService.GetProductsWithCategories();
            var map = _mapper.Map<List<ResultProductDto>>(products);
            return Ok(map);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            var map = _mapper.Map<Product>(createProductDto);
            await _productService.AddAsync(map);
            return Ok("Ürün Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var value = await _productService.GetByIDAsync(id);
            await _productService.DeleteAsync(value);
            return Ok("Ürün Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var value = await _productService.GetByIDAsync(id);
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            var map = _mapper.Map<Product>(updateProductDto);
            await _productService.UpdateAsync(map);
            return Ok("Ürün Bilgisi Güncellendi");
        }
    }
}
