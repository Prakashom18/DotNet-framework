using Microsoft.AspNetCore.Mvc;

namespace SimpleInterestCalculator.Controllers
{
    public class SIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Models.SI obj)
        {
            ViewBag.Result = (obj.P * obj.Q * obj.R) / 100;
            return View();
        }
    }
}
