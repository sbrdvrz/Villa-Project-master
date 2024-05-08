using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.Admin
{
    public class _AdminFooterComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
