using Microsoft.AspNetCore.Mvc;
using MVCTraining.Models;

namespace MVCTraining.Controllers
{
    public class VeriController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Berkay";
            ViewData["Name"] = "Akar";
            TempData["Message"] = "Bu tempdata ile gelen bir mesajdır. Lütfen dikkate almayınız";

            BerkayModel m = new BerkayModel() { Id = 1, Name = "Muhammed Berkay Akar", Age = 123 };
            return View(m);
        }
    }
}
