using Microsoft.AspNetCore.Mvc;

namespace BorkarEmlakUI.ViewComponents
{
    public class Info:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
