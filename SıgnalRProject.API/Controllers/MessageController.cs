using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SıgnalRProject.Dto.MessageDto;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;

namespace SıgnalRProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;
        private readonly IValidator<CreateMessageDto> validator;
        private readonly IMapper _mapper;

		public MessageController(IMessageService messageService, IValidator<CreateMessageDto> validator, IMapper mapper)
		{
			_messageService = messageService;
			this.validator = validator;
			_mapper = mapper;
		}

		[HttpGet]
        public async Task<IActionResult> MessageList()
        {
            var values = await _messageService.GetAllAsync();
            return Ok(values);
        }
        [HttpPost("CreateMessage")]
        public async Task<IActionResult> CreateMessage(CreateMessageDto createMessageDto)
        {
            var result = validator.Validate(createMessageDto);
			if (!result.IsValid)
			{
				return BadRequest(result);
			}
			try
            {
				var map = _mapper.Map<Message>(createMessageDto);
				map.Status = false;
				map.MessageSendDate = DateTime.Now;
				await _messageService.AddAsync(map);
				return Ok(new { success = true, message = "Rezervasyon Yapıldı" });
			}
            catch (Exception ex)
            {

				return BadRequest(new { success = false, message = ex.Message });
			}

           
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            var value = await _messageService.GetByIDAsync(id);
            await _messageService.DeleteAsync(value);
            return Ok("Mesaj Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            var map = _mapper.Map<Message>(updateMessageDto);
            map.Status = false;
            await _messageService.UpdateAsync(map);
            return Ok("Mesaj Bilgisi Güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMessage(int id)
        {
            var value = await _messageService.GetByIDAsync(id);
            return Ok(value);
        }
    }
}
