using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class AdditionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection obj)
        {
            int num1 = Convert.ToInt32(obj["textbox1"]);
            int num2 = Convert.ToInt32(obj["textbox2"]);
            int result = num1 + num2;
            ViewBag.data = "Result is" + result;

            return View();

        }
    }
   
}
