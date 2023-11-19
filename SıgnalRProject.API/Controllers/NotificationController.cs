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
        public IActionResult NotificationList()
        {
            var notitifications = _notificationService.GetAllAsync();
            var maps = _mapper.Map<ResultNotificationDto>(notitifications);
            return Ok(maps);

        }
        [HttpGet("NotificationCountByStatusFalse")]
        public IActionResult NotificationCountByStatusFalse()
        {
            return Ok(_notificationService.NotificationCountByStatusFalse());
        }
        [HttpGet("GetAllNotificationByFalse")]
        public IActionResult GetAllNotificationByFalse()
        {
            return Ok(_notificationService.GetAllNotificationByFalse());
        }
        [HttpPost]
        public async Task< IActionResult> CreateNotification(CreateNotificationDto createNotificationDto)
        {
            var map = _mapper.Map<Notification>(createNotificationDto);
            await _notificationService.AddAsync(map);
            return Ok("Ekleme işlemi başarıyla yapıldı");
        }
        [HttpDelete("{id}")]
        public async Task< IActionResult> DeleteNotification(int id)
        {
            var value =await  _notificationService.GetByIDAsync(id);
            await _notificationService.DeleteAsync(value);
            return Ok("Bildirim Silindi");
        }
        [HttpGet("{id}")]
        public async Task< IActionResult> GetNotification(int id)
        {
            var value = await _notificationService.GetByIDAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
        {
            var map = _mapper.Map<Notification>(updateNotificationDto);
            _notificationService.UpdateAsync(map);
            return Ok("Güncelleme işlemi başarıyla yapıldı");
        }
        [HttpGet("NotificationStatusChangeToFalse/{id}")]
        public IActionResult NotificationStatusChangeToFalse(int id)
        {
            _notificationService.NotificationStatusChangeToFalse(id);
            return Ok("Güncelleme yapıldı");
        }
        [HttpGet("NotificationStatusChangeToTrue/{id}")]
        public IActionResult NotificationStatusChangeToTrue(int id)
        {
            _notificationService.NotificationStatusChangeToTrue(id);
            return Ok("Güncelleme yapıldı");
        }
    }
}
