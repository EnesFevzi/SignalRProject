using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SıgnalRProject.Service.Services.Abstract;

namespace SıgnalRProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyCasesController : ControllerBase
    {
        private readonly IMoneyCaseService _moneyCaseService;

        public MoneyCasesController(IMoneyCaseService moneyCaseService)
        {
            _moneyCaseService = moneyCaseService;
        }

        [HttpGet]
        public async Task<IActionResult> TotalMoneyCaseAmount()
        {
            return Ok(await _moneyCaseService.TotalMoneyCaseAmount());
        }
    }
}
