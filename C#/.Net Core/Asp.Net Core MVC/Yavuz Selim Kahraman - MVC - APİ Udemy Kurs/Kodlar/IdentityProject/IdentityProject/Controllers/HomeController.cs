using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
