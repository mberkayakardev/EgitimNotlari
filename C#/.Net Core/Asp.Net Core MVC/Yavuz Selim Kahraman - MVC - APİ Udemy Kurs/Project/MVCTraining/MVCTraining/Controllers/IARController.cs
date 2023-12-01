using Microsoft.AspNetCore.Mvc;

namespace MVCTraining.Controllers
{
    public class IARController : Controller
    {
        public IActionResult Index()
        {
            ITers t = new Test(); // t bir Test örneği 
            ITers t2 = new Test2(); // t2 bir Test2 örneği 

            // IOC 

            ViewResult deneme = View();
            RedirectResult deneme2 = Redirect("");
            RedirectToActionResult deneme3 = RedirectToAction("Index2");
            // Görülen sınıflar aslında methodların dönüş tipindeki Class karşılıklarıdır bunların hepsini IActionResuılt toplar 
            // burdan yola çıkarak aynı methodda diğer veri tiplerini çevirebilmek ve tek bir tip üzerinden tüm tiplerle iş yapabilmek için IActionResult Toplayıcı bir tip olarak karşımıza çıkar. 

            if (true)
                return View();

            else
                return RedirectToAction("");

            // eğer dönüş ttipimiz viewresult olsaydı rediretToAction i buı şekilde kullanamazdık. Genel Hatları ile görüldüğü gibi Toplayıcı bir tiptir. 
        }

    }


    public interface ITers
    { // İnterface imiz 
    }
    public class Test : ITers
    {// interfaceten kalıtım alan Test sınıfı 
    }
    public class Test2 : ITers
    {// interfaceten kalıtım alan Test2 sınıfı 
    }
}
