using Microsoft.AspNetCore.Mvc;

namespace VetClinic.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AuthController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
