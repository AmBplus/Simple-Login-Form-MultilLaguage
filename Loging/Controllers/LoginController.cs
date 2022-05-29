using Loging.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loging.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            if (!ModelState.IsValid) return View();
            return RedirectToAction("Succeed");
        }

        public IActionResult Succeed(User user)
        {
            return View();
        }
    }
}
