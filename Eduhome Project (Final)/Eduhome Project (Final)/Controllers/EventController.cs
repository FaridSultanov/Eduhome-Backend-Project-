using Microsoft.AspNetCore.Mvc;

namespace Eduhome_Project__Final_.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Event()
        {
            return View();
        }

        public IActionResult EventLeftSideBar()
        {
            return View();
        }

        public IActionResult EventDetails()
        {
            return View();
        }
    }
}
