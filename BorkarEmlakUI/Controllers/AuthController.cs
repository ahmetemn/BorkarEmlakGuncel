using BorkarEmlak.DATA.Concrate;
using BorkarEmlakUI.Models.AuthVMs;
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


        [HttpPost]

        public async Task<IActionResult> Login(LoginVm loginVm , string? ReturnUrl)
        {

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginVm.UserName, loginVm.Password, false, false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(loginVm.UserName);
                    if (user != null)
                    {
                        if (!string.IsNullOrEmpty(ReturnUrl))
                        {
                            return Redirect(ReturnUrl);
                        }
                        //amacı user 'ı bulup userId yi cookie ye yazdırmak

                        Response.Cookies.Append("UserId", user.Id);

                    }

                    return RedirectToAction("Index", "Home");

                
                }

                else
                {

                    ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre"); 
                }
            }
   
            return View(loginVm);
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Register(RegisterVM registerVM)
        {

            var user = new AppUser
            {
                Email=registerVM.Email,
                PhoneNumber=registerVM.PhoneNumber,
                UserName=registerVM.UserName,   
            };

            var result = await _userManager.CreateAsync(user,registerVM.Password);

            if (result.Succeeded)
            {

                TempData["KayıtBasarili"] = "Kayıt İşleminiz Başarıyla Gerçekleşti";  
                await _signInManager.PasswordSignInAsync(registerVM.UserName, registerVM.Password , false , false);
                return RedirectToAction("Login"); 
            }
            else
            {

                TempData["KayıtBasarisiz"] = "Kayit İşlemi Başarisiz";
                foreach (IdentityError item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }

            return View();
        } 
    }
}
