using BorkarEmlak.DATA.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BorkarEmlakUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> _userManager; 
        private readonly SignInManager<AppUser> _signInManager;     
        private readonly RoleManager<AppRole> _roleManager;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Login()
        {
            return View();  
        }
    }
}
