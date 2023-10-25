var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // MVC için ilgili servis eklendi. 

var app = builder.Build();

app.UseRouting(); // gelen requestlerin controller ile eşleyecek middleware 

app.UseEndpoints(enpoint => {
    enpoint.MapControllerRoute(name : "Default" , 
                               pattern: "{controller}/{action}/{id?}", 
                               defaults: new {controller = "Home" , action = "Index"});
}); // Execute edilecek olan rota şablonu oluşturuldu

app.Run();
