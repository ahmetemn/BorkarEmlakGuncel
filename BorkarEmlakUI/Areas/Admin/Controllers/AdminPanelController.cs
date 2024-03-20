using Microsoft.AspNetCore.Mvc;

namespace BorkarEmlakUI.Areas.Admin.Controllers
{
    public class AdminPanelController : Controller
    {
        [Area("Admin")]
        public IActionResult AdminSayfasi()
        {
            return View();
        }
    }
}
