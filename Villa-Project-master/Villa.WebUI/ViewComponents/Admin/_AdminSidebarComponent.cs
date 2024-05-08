using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.Admin
{
    public class _AdminSidebarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
