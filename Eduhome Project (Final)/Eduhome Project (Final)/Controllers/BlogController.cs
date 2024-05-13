using Microsoft.AspNetCore.Mvc;

namespace Eduhome_Project__Final_.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult BlogLeftSideBar()
        {
            return View();
        }

        public IActionResult BlogDetails()
        {
            return View();
        }
    }
}
