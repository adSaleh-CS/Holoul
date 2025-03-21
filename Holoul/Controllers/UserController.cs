using Microsoft.AspNetCore.Mvc;

namespace Holoul.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
