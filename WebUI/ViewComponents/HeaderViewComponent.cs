using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace WebUI.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        public ViewViewComponentResult Invoke(int selection)
        {
            return View();
        }
    }
}
