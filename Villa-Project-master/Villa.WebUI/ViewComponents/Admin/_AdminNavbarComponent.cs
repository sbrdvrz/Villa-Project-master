using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.Admin
{
    public class _AdminNavbarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
