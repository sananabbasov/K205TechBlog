using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.dashboard.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<K205User> _userManager;
        private readonly SignInManager<K205User> _signInManager;

        public AuthController(UserManager<K205User> userManager, SignInManager<K205User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
