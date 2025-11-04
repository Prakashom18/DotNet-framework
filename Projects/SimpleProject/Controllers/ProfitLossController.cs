using Microsoft.AspNetCore.Mvc;

namespace SimpleProject.Controllers
{
    public class ProfitLossController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Models.ProfitLoss obj)
        {
            float sp = obj.SP;
            float cp = obj.CP;
            if (sp > cp)
            {
                ViewBag.Result = "Profit Amount:" + (sp - cp);
            }
           else if (cp > sp)
            {
                ViewBag.Result = "loss" + (cp - sp);
            }
            else
            {
                ViewBag.Result = "No Profit No Loss";
            }
               return View();

        }
    }
}
