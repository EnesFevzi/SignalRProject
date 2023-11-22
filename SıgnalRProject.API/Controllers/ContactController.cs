using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SıgnalRProject.Dto.ContactDto;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;

namespace SıgnalRProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            var contacts = await _contactService.GetAllAsync();
            var value = _mapper.Map<List<ResultContactDto>>(contacts);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
        {
            var map = _mapper.Map<Contact>(createContactDto);
            await _contactService.AddAsync(map);
            return Ok("İletişim Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var value = await _contactService.GetByIDAsync(id);
            await _contactService.DeleteAsync(value);
            return Ok("İletişim Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {
            var value =await _contactService.GetByIDAsync(id);
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactDto updateContactDto)
        {
            var map = _mapper.Map<Contact>(updateContactDto);
            await _contactService.UpdateAsync(map);
            return Ok("İletişim Bilgisi Güncellendi");
        }
    }
}
