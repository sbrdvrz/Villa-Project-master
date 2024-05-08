using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.Admin
{
    public class _AdminLogoComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
