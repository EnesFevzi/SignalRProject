using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SıgnalRProject.Dto.AboutDto;
using SıgnalRProject.Dto.BookingDto;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using SıgnalRProject.Service.Services.Concrete;

namespace SıgnalRProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> BookingList()
        {
            var values = await _bookingService.GetAllAsync();
            var map = _mapper.Map<List<ResultBookingDto>>(values);
            return Ok(map);
        }
        [HttpPost("CreateBooking")]
        public async Task<IActionResult> CreateBooking(CreateBookingDto createBookingDto)
        {
            try
            {
                var map = _mapper.Map<Booking>(createBookingDto);
                await _bookingService.AddAsync(map);

                return Ok(new { success = true, message = "Rezervasyon Yapıldı" });
            }
            catch (Exception ex)
            {
                // Hata durumunda
                return BadRequest(new { success = false, message = ex.Message });
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var value = await _bookingService.GetByIDAsync(id);
            await _bookingService.DeleteAsync(value);
            return Ok("Rezervasyon Silindi");
        }
        [HttpPut("UpdateBooking")]
        public async Task<IActionResult> UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            var map = _mapper.Map<Booking>(updateBookingDto);
           await _bookingService.UpdateAsync(map);
            return Ok("Rezervasyon Güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBooking(int id)
        {
            var value =  await _bookingService.GetByIDAsync(id);
            return Ok(value);
        }
        [HttpGet("BookingStatusApproved/{id}")]
        public async Task<IActionResult> BookingStatusApproved(int id)
        {
           await _bookingService.BookingStatusApproved(id);
            return Ok("Rezervasyon Açıklaması Değiştirildi");
        }
        [HttpGet("BookingStatusCancelled/{id}")]
        public async Task<IActionResult> BookingStatusCancelled(int id)
        {
            await _bookingService.BookingStatusCancelled(id);
            return Ok("Rezervasyon Açıklaması Değiştirildi");
        }
    }
}
