using Microsoft.AspNetCore.Mvc;

namespace SıgnalRProject.WebUI.ViewComponents
{
    public class _DefaultBookATableViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
