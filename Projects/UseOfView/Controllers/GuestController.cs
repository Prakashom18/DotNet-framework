using Microsoft.AspNetCore.Mvc;

namespace UseOfView.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.a = 10;
            ViewData["b"] = 1000;
            TempData["c"] = 1000;
            return View();
        }
    }
}
