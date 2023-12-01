using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

#region Services
builder.Services.AddControllersWithViews();
#endregion

var app = builder.Build();

#region Endpoints 

app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions {  RequestPath = "/mahmut", FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "berkay"))});


app.UseRouting();

app.UseEndpoints(x => x.MapControllerRoute(name: "defaults", pattern: "{controller=Product}/{Action=Index}/{id?}/{berkayozelprop?}")); // Özel olan route her zaman daha yukarı yazılması gerekecektir. 

app.UseEndpoints(x => x.MapControllerRoute(name: "defaults", pattern: "Berkay", defaults: new { controller = "IAR", action = "Index" })); // Özel olan route her zaman daha yukarı yazılması gerekecektir. 

app.UseEndpoints(x=> x.MapControllerRoute(name: "defaults", pattern: "{controller=IAR}/{action=Index}/{id?}" , defaults: new {controller = "IAR", action = "Index"}));

#endregion

app.Run();
