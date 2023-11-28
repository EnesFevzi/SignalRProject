using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SıgnalRProject.WebUI.Controllers
{
    [Authorize]
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
		
	}
}
