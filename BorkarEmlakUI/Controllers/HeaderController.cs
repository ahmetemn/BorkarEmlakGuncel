using Microsoft.AspNetCore.Mvc;

namespace BorkarEmlakUI.Controllers
{
    public class HeaderController : Controller
    {
        public IActionResult Header()
        {
            return View();
        }
    }
}
