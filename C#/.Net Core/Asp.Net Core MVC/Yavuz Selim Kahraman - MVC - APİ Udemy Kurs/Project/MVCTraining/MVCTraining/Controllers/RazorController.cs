using Microsoft.AspNetCore.Mvc;

namespace MVCTraining.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
