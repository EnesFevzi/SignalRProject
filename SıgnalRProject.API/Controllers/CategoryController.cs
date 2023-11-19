using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SıgnalRProject.Dto.CategoryDto;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;

namespace SıgnalRProject.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService _categoryService;
		private readonly IMapper _mapper;
		public CategoryController(ICategoryService categoryService, IMapper mapper)
		{
			_categoryService = categoryService;
			_mapper = mapper;
		}
		[HttpGet("CategoryList")]
		public async Task<IActionResult> CategoryList()
		{
			var categories = await _categoryService.GetAllAsync();
			var value = _mapper.Map<List<ResultCategoryDto>>(categories);
			return Ok(value);
		}

		[HttpGet("CategoryCount")]
		public IActionResult CategoryCount()
		{
			return Ok(_categoryService.CategoryCount());
		}

		[HttpGet("ActiveCategoryCount")]
		public IActionResult ActiveCategoryCount()
		{
			return Ok(_categoryService.ActiveCategoryCount());
		}

		[HttpGet("PassiveCategoryCount")]
		public IActionResult PassiveCategoryCount()
		{
			return Ok(_categoryService.PassiveCategoryCount());
		}

		[HttpPost]
		public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
		{
			var map = _mapper.Map<Category>(createCategoryDto);
			await _categoryService.AddAsync(map);
			return Ok("Kategori Eklendi");
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCategory(int id)
		{
			var value = await _categoryService.GetByIDAsync(id);
			await _categoryService.DeleteAsync(value);
			return Ok("Kategori Silindi");
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetCategory(int id)
		{
			var value = await _categoryService.GetByIDAsync(id);
			return Ok(value);
		}
		[HttpPut]
		public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
		{
			var map = _mapper.Map<Category>(updateCategoryDto);
			await _categoryService.UpdateAsync(map);
			return Ok("Kategori Güncellendi");
		}
	}
}
