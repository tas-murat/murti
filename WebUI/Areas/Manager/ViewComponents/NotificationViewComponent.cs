using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace WebUI.Areas.Manager.ViewComponents
{
    public class NotificationViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke(int selection)
        {
            return View();
        }
    }
}
