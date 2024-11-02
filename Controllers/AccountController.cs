using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SellphoneC.Models;

namespace SellphoneC.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager) 
        {
            this.signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
