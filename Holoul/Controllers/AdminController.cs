using Microsoft.AspNetCore.Mvc;

namespace Holoul.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult categories()
        {
            return View();
        }
        public IActionResult feedback()
        {
            return View();
        }
        public IActionResult problemsandsolutions()
        {
            return View();
        }
        public IActionResult profile()
        {
            return View();
        }
        public IActionResult reports()
        {
            return View();
        }
    }
}
