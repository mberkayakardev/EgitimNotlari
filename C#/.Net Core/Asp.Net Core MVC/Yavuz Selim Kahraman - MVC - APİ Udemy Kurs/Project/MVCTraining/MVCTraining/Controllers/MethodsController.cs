 using Microsoft.AspNetCore.Mvc;

namespace MVCTraining.Controllers
{
    public class MethodsController : Controller
    {
        // View methodu : içerisinde bulunduğu Action methodu ile (action un ismmi) aynı isimdeki view i gelir bana gösterir. 
        // yani methodun ismindeki view i ilgili controller yada shared içerisidne arar ve method ismindeki viewi  getirir 
        public IActionResult Index()
        { 
            // Index Viewini getirecek 
            return View();
        }

        public IActionResult Ahmet()
        {
            // Ahmet Viewini getirecek 
            return View();
        }

        public IActionResult Mehmet()
        {
            // Mehmet Viewini getirecek 
            return View();
        }
        public IActionResult Hasan()
        {
            // Evet method ismi Hasan ama view içerisinde isim belirtilmiş Huseyin ismindeki viewi bulup getirecek
            return View("Huseyin");
        }





    }
}
