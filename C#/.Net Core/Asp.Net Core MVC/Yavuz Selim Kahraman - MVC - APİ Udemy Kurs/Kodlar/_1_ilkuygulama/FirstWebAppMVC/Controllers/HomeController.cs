using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FirstWebAppMVC.asdasdasd
{
    public class HomeController : Controller // Web api uygulamaları için Base controller üzerinden kalıtım alınması gerekecektir.
    {
        [HttpGet]
        public async IActionResult Index()
        {
            await deneme();
            var b = await deneme2();
            return View();
        }

        public void sonuc1()
        {

        }

        public int sonuc2()
        {
            return 6;
        }

        //public Task deneme()
        //{
        //    return Task.Run( () => { return }) ;
        //}

        //public Task<int> deneme2()
        //{
        //    return Task.Run( ()=>
        //    {
        //        return 3;
        //    });
        //}

        public Task deneme()
        {
            return Task.Run(sonuc2);
        }

        public Task<int> deneme2()
        {
            return Task.Run(sonuc2);
        }

    }
}
