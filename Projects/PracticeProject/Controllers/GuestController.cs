using Microsoft.AspNetCore.Mvc;

namespace PracticeProject.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Careers()
        {
            return View();
        }
    }
}
