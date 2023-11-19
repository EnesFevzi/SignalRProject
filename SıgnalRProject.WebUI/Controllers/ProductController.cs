using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.WebUI.DTOs.CategoriesDto;
using SıgnalRProject.WebUI.DTOs.ProductDto;
using System.Text;

namespace SıgnalRProject.WebUI.Controllers
{
	public class ProductController : Controller
	{
		private const string link = "https://localhost:7024/api";

		private readonly IHttpClientFactory _httpClientFactory;
		public ProductController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"{link}/Product/ProductListWithCategory");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
				return View(values);
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> CreateProduct()
		{
			var client = _httpClientFactory.CreateClient();
			var categoryResponse = await client.GetAsync($"{link}/Category/CategoryList");
			if (categoryResponse.IsSuccessStatusCode)
			{
				var categoryJson = await categoryResponse.Content.ReadAsStringAsync();
				var categories = JsonConvert.DeserializeObject<List<Category>>(categoryJson);
				var viewModel = new CreateProductDto
				{
					Categories = categories,
				};
				return View(viewModel);
			}

			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
		{
			createProductDto.ProductStatus = true;
			var client = _httpClientFactory.CreateClient();
			var categoryResponse = await client.GetAsync($"{link}/Category");
			var jsonData = JsonConvert.SerializeObject(createProductDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync($"{link}/Product", stringContent);

			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			var categoryJson = await categoryResponse.Content.ReadAsStringAsync();
			var categories = JsonConvert.DeserializeObject<List<Category>>(categoryJson);
			var viewModel = new CreateProductDto
			{
				Categories = categories,
			};
			return View(viewModel);
		}
		public async Task<IActionResult> DeleteProduct(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"{link}/Product/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> UpdateProduct(int id)
		{

			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"{link}/Product/{id}");
			var categoryResponse = await client.GetAsync($"{link}/Category/CategoryList");
			if (responseMessage.IsSuccessStatusCode && categoryResponse.IsSuccessStatusCode)
			{
				var categoryJson = await categoryResponse.Content.ReadAsStringAsync();
				var categories = JsonConvert.DeserializeObject<List<Category>>(categoryJson);
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateProductDto>(jsonData);
				values.Categories = categories;
				return View(values);
			}
			var categoryJson2 = await categoryResponse.Content.ReadAsStringAsync();
			var categories2 = JsonConvert.DeserializeObject<List<Category>>(categoryJson2);
			var viewModel = new CreateProductDto
			{
				Categories = categories2,
			};
			return View(viewModel);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
		{
			updateProductDto.ProductStatus = true;
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateProductDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync($"{link}/Product/", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
