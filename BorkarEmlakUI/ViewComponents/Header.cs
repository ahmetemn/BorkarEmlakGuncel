using Microsoft.AspNetCore.Mvc;

namespace BorkarEmlakUI.ViewComponents
{
    public class Header:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
