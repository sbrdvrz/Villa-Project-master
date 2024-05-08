using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.Admin
{
    public class _AdminScriptComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
