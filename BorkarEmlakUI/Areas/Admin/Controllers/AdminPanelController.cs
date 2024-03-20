using Microsoft.AspNetCore.Mvc;

namespace BorkarEmlakUI.Areas.Admin.Controllers
{
    public class AdminPanelController : Controller
    {
        public IActionResult AdminSayfasi()
        {
            return View();
        }
    }
}
