using Microsoft.AspNetCore.Mvc;

namespace MyHealthLife.Web.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View("~/Views/Auth/Login.cshtml");
        }
    }
}
