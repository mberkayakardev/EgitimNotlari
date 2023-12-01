
using Microsoft.AspNetCore.Mvc;
namespace Commandpromtfirstapp.Controllers 
{
    public class Home : Controller
    {
        public IActionResult Index(){
            
            return View();
        }

    }
}