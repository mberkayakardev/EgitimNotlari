namespace MVCTraining.Models.Db
{
    public class MyDbContext
    {
        public static List<Product> Products = new List<Product>() { 
            new Product() { ProductId = Guid.NewGuid().ToString(), Money = 120, ProductDescription = "Güzel Telefon", ProductName = "İphone 14" } ,
            new Product() { ProductId = Guid.NewGuid().ToString(), Money = 150, ProductDescription = "Güzel Telefon", ProductName = "İphone 15 Pro" },
            new Product() { ProductId = Guid.NewGuid().ToString(), Money = 2500, ProductDescription = "Güzel bilgisayar ", ProductName = "Monster Laptop" },
            new Product() { ProductId = Guid.NewGuid().ToString(), Money = 35, ProductDescription = "Güzel kahve makinesi türk kahvesi ve Expresso yapabilir ", ProductName = "Kahve Makinesi" }
        };
    }
}
