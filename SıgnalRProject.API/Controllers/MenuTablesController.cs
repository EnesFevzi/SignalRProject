using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SıgnalRProject.Dto.BookingDto;
using SıgnalRProject.Dto.MenuTableDto;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;

namespace SıgnalRProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTablesController : ControllerBase
    {
        private readonly IMenuTableService _menuTableService;
        private readonly IMapper _mapper;

        public MenuTablesController(IMenuTableService menuTableService, IMapper mapper)
        {
            _menuTableService = menuTableService;
            _mapper = mapper;
        }

        [HttpGet("MenuTableCount")]
        public async Task<IActionResult> MenuTableCount()
        {
            var value = await _menuTableService.MenuTableCount();
            return Ok(value);
        }
        [HttpGet]
        public async Task<IActionResult> MenuTableList()
        {
            var values = await _menuTableService.GetAllAsync();
            var map = _mapper.Map<List<MenuTable>>(values);
            return Ok(map);
        }
        [HttpPost]
        public async Task<IActionResult> CreateMenuTable(CreateMenuTableDto createMenuTableDto)
        {
            var map = _mapper.Map<MenuTable>(createMenuTableDto);
            await _menuTableService.AddAsync(map);
            return Ok("Masa Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenuTable(int id)
        {
            var value = await _menuTableService.GetByIDAsync(id);
            await _menuTableService.DeleteAsync(value);
            return Ok("Masa Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateMenuTable(UpdateMenuTableDto updateMenuTableDto)
        {
            var map = _mapper.Map<MenuTable>(updateMenuTableDto);
            await _menuTableService.UpdateAsync(map);
            return Ok("Masa Bilgisi Güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMenuTable(int id)
        {
            var value = await _menuTableService.GetByIDAsync(id);
            var map = _mapper.Map<GetMenuTableDto>(value);
            return Ok(map);
        }
    }
}
