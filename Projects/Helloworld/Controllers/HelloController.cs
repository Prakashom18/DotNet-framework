using Microsoft.AspNetCore.Mvc;

namespace Helloworld.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
