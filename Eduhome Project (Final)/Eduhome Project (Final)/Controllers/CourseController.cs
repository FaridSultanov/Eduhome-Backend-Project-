using Microsoft.AspNetCore.Mvc;

namespace Eduhome_Project__Final_.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Course()
        {
            return View();
        }

        public IActionResult CourseDetails()
        {
            return View();
        }
    }
}
