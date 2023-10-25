using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace FirstWebAppMVC.Controllers
{
    public class asdController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            ViewBag.Name = "Berkay";
            ViewBag.Dersler = new List<string> { "Fizik", "Kimya", "Biyoloji" };

            ViewData["yas"] = 12;
            ViewData["Sehirler"] = new List<string> { "İstanbul", "İzmir", "Aydın" };


            TempData["UYARI"] = "index 2 den veri geldi ";

            return RedirectToAction("Index3");
            //return View();
        }


        public IActionResult Index3()
        {
            if (TempData["UYARI"] == null)
            {
                TempData["UYARI"] = "index 2 den veri gelmedi burda index 3 ün life cycle i geçerli ";
            }
            
            return RedirectToAction("Index4");

        }


        public IActionResult Index4()
        {
            if (TempData["UYARI"] == null)
            {
                TempData["UYARI"] = "index 4 her çağrıldığında httpsession biter  o yüzden index2 veya 3 cağrılmış olsa bile sonrasında 4 ü direk çağırdığında veri boşa düştü  ";
            }
            return View();
        }
    }
}
