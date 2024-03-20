using Microsoft.AspNetCore.Mvc;

namespace BorkarEmlakUI.ViewComponents
{
    public class EnSonEklenenler:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
