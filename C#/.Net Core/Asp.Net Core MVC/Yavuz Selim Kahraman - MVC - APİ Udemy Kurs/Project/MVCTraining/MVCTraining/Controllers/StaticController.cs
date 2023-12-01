using Microsoft.AspNetCore.Mvc;

namespace MVCTraining.Controllers
{
    public class StaticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
    }
}
