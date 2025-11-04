using Microsoft.AspNetCore.Mvc;

namespace UseOfView.Models
{
    public class SampleModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
