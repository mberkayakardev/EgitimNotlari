using Microsoft.AspNetCore.Mvc;
using MVCTraining.Models;
using MVCTraining.Models.Db;

namespace MVCTraining.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var model = MyDbContext.Products.ToList();
            return View(model);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateWithForm()
        {
            var ProductName = HttpContext.Request.Form["ProductName"];
            var ProductMoney = HttpContext.Request.Form["Money"];
            var Description = HttpContext.Request.Form["ProductDescription"];

            var product = new Product();
            product.ProductId = Guid.NewGuid().ToString();
            product.ProductName = ProductName;
            product.Money =Convert.ToDecimal(ProductMoney);
            product.ProductDescription = Description;

            MyDbContext.Products.Add(product);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete()
        {
            var id = RouteData.Values["id"];
            var silinecekData = MyDbContext.Products.FirstOrDefault(x=> x.ProductId == id.ToString());
            MyDbContext.Products.Remove(silinecekData);
            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult Update()
        {
            var id = RouteData.Values["id"];
            var model = MyDbContext.Products.FirstOrDefault(x => x.ProductId == id.ToString());
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateWithForm()
        {
            var id = HttpContext.Request.Form["ProductId"].ToString();
            var model = MyDbContext.Products.FirstOrDefault(x => x.ProductId == id);
            model.ProductName = HttpContext.Request.Form["ProductName"].ToString();
            model.ProductDescription = HttpContext.Request.Form["ProductDescription"].ToString();
            model.Money = Convert.ToDecimal(HttpContext.Request.Form["Money"]);

            return RedirectToAction("Index");
        }
    }
}
