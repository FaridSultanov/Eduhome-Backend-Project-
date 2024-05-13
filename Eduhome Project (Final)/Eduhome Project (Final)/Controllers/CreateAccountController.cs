using Microsoft.AspNetCore.Mvc;

namespace Eduhome_Project__Final_.Controllers
{
    public class CreateAccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
    }
}
