using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SıgnalRProject.Dto.NotificationDto;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;

namespace SıgnalRProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        private readonly IMapper _mapper;

        public NotificationController(INotificationService notificationService, IMapper mapper)
        {
            _notificationService = notificationService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> NotificationList()
        {
            var notitifications = await _notificationService.GetAllAsync();
            var maps = _mapper.Map<ResultNotificationDto>(notitifications);
            return Ok(maps);

        }
        [HttpGet("NotificationCountByStatusFalse")]
        public async Task<IActionResult> NotificationCountByStatusFalse()
        {
            return Ok(await _notificationService.NotificationCountByStatusFalse());
        }
        [HttpGet("GetAllNotificationByFalse")]
        public async Task<IActionResult> GetAllNotificationByFalse()
        {
            return Ok(await _notificationService.GetAllNotificationByFalse());
        }
        [HttpPost]
        public async Task<IActionResult> CreateNotification(CreateNotificationDto createNotificationDto)
        {
            var map = _mapper.Map<Notification>(createNotificationDto);
            await _notificationService.AddAsync(map);
            return Ok("Ekleme işlemi başarıyla yapıldı");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNotification(int id)
        {
            var value = await _notificationService.GetByIDAsync(id);
            await _notificationService.DeleteAsync(value);
            return Ok("Bildirim Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNotification(int id)
        {
            var value = await _notificationService.GetByIDAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateNotification(UpdateNotificationDto updateNotificationDto)
        {
            var map = _mapper.Map<Notification>(updateNotificationDto);
            await _notificationService.UpdateAsync(map);
            return Ok("Güncelleme işlemi başarıyla yapıldı");
        }
        [HttpGet("NotificationStatusChangeToFalse/{id}")]
        public async Task<IActionResult> NotificationStatusChangeToFalse(int id)
        {
            await _notificationService.NotificationStatusChangeToFalse(id);
            return Ok("Güncelleme yapıldı");
        }
        [HttpGet("NotificationStatusChangeToTrue/{id}")]
        public async Task<IActionResult> NotificationStatusChangeToTrue(int id)
        {
            await _notificationService.NotificationStatusChangeToTrue(id);
            return Ok("Güncelleme yapıldı");
        }
    }
}
