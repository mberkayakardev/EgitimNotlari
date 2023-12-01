using Microsoft.AspNetCore.Mvc;

namespace MVCTraining.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var routeValues = RouteData.Values;
            var routeValues2 = RouteData.Values["Controller"];
            var routeValues3 = RouteData.Values["Action"];
            var routeValues4 = RouteData.Values["berkayozelroute"];

            // Olmayan bir key gelirse hata atmaz. null döner


            return View();
        }
    }
}
