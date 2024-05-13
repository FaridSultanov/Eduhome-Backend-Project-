using Microsoft.AspNetCore.Mvc;

namespace Eduhome_Project__Final_.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
