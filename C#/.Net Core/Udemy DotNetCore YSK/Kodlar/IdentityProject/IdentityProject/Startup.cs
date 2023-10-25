using IdentityProject.Context;
using IdentityProject.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<MyCostumeUser,MyCostumeRoles>(
                opt =>
                {
                    opt.Password.RequireDigit = false; // sayısal karakter içerme zorunluluğu burada ezildi.
                    opt.Password.RequiredLength = 5; // minimum 5 karakter ile işlem yapılacaktır. 
                    opt.Password.RequireUppercase = false; // en az bir büyük karakter gerekliliği kaldırıldı. 

                }).AddEntityFrameworkStores<UdemyContext>();
            services.AddDbContext<UdemyContext>(
            opt =>
            {
                opt.UseSqlServer("Data Source=DESKTOP-SKDUDAU;Database=IdentityFirstApp; User ID=locallogin;Password=1234;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            
            });  // burada contextimize ilgil ayarlama sağlandı. 
            services.AddControllersWithViews();
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();


            app.UseStaticFiles(); // wwwroot açıldı
            app.UseStaticFiles( new StaticFileOptions {RequestPath = "/node_modules" , FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"node_modules"))  });
            // node_modules açıldı.
            
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
