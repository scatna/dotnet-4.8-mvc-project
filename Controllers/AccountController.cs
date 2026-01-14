using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class AccountController : Controller
    {
        // TODO: Implement ASP.NET Core Identity authentication
        // This controller has been simplified for the migration
        // Original complex authentication logic needs to be reimplemented
        
        public IActionResult Login()
        {
            return View();
        }
        
        public IActionResult Register()
        {
            return View();
        }
        
        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
