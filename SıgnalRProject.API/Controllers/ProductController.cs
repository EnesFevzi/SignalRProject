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
        public async Task<IActionResult> ProductList()
        {
            var products =await _productService.GetAllAsync();
            var value = _mapper.Map<List<ResultProductDto>>(products);
            return Ok(value);
        }

        [HttpGet("ProductCount")]
        public async Task<IActionResult> ProductCount()
        {
            return Ok(await _productService.ProductCount());
        }

        [HttpGet("TotalPriceByDrinkCategory")]
        public async Task<IActionResult> TotalPriceByDrinkCategory()
        {
            return Ok(await _productService.TotalPriceByDrinkCategory());
        }

        [HttpGet("TotalPriceBySaladCategory")]
        public async Task<IActionResult> TotalPriceBySaladCategory()
        {
            return Ok(await _productService.TotalPriceBySaladCategory());
        }

        [HttpGet("ProductNameByMaxPrice")]
        public async Task<IActionResult> ProductNameByMaxPrice()
        {
            return Ok(await _productService.ProductNameByMaxPrice());
        }

        [HttpGet("ProductNameByMinPrice")]
        public async Task<IActionResult> ProductNameByMinPrice()
        {
            return Ok(await _productService.ProductNameByMinPrice());
        }

        [HttpGet("ProductAvgPriceByHamburger")]
        public async Task<IActionResult> ProductAvgPriceByHamburger()
        {
            return Ok(await _productService.ProductAvgPriceByHamburger());
        }

        [HttpGet("ProductCountByHamburger")]
        public async Task<IActionResult> ProductCountByHamburger()
        {
            return Ok(await _productService.ProductCountByCategoryNameHamburger());
        }

        [HttpGet("ProductCountByDrink")]
        public async Task<IActionResult> ProductCountByDrink()
        {
            return Ok(await _productService.ProductCountByCategoryNameDrink());
        }

        [HttpGet("ProductPriceAvg")]
        public async Task<IActionResult> ProductPriceAvg()
        {
            return Ok(await _productService.ProductPriceAvg());
        }

        [HttpGet("ProductPriceBySteakBurger")]
        public async Task<IActionResult> ProductPriceBySteakBurger()
        {
            return Ok(await _productService.ProductPriceBySteakBurger());
        }

        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var products = await _productService.GetProductsWithCategories();
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
