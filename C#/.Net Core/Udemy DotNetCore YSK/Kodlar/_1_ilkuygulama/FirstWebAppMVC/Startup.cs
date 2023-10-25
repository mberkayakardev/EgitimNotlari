using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebAppMVC
{
    public class Startup
    {
 

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc(); // Tüm uygulama tiplerini destekleyen genel bir serviz
            services.AddControllersWithViews(); // Views i destekler bu sebeple bizler uygulama yazarken bunu kullancağız // Blazor u desteklemez. 

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute( name:"Default" , pattern: "{controller=Home}/{action=Index}/{id?}");
            //});


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "Default", pattern: "{controller}/{action}/{id?}" , defaults : new {Controller = "asd" , Action = "Index" });
            });

            //app.UseEndpoints(x => x.MapDefaultControllerRoute()); // Controller / Action / id tanımlamasını varsayılanda direk yapmakj için kullanılır. özel bir tanımlama yapmak istersen yada uzun uzun yazmak istersen patterni üsteki gibi yaz

        }
    }
}
