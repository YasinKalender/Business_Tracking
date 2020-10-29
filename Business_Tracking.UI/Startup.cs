using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business_Tracking.Business.Abstract;
using Business_Tracking.Business.Concrete;
using Business_Tracking.Business.FluentValidation;
using Business_Tracking.Business.RepositoryContainer;
using Business_Tracking.DAL.Context;
using Business_Tracking.DTOs.DTOs;
using Business_Tracking.DTOs.DTOs.AppUserDto;
using Business_Tracking.DTOs.DTOs.JobsDto;
using Business_Tracking.DTOs.DTOs.RaporsDto;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.Repository.Repository.Abstract;
using Business_Tracking.Repository.Repository.Concrete;
using Business_Tracking.UI.CustomCollectionExtension;
using Business_Tracking.UI.IdentityInitilazer;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Business_Tracking.UI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Add();

            //AutoMapperi ekledik
            services.AddAutoMapper(typeof(Startup));
            services.AddValidator();

            //Validation kurallarýný ekledik..
            services.AddControllersWithViews().AddFluentValidation();

            //Veritabaný ayarlarý
            services.AddDbContext<ProjectContext>();

            services.AddIdentity();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //Delevoper modda ise hatalarý göster
            }

            else
            {
                app.UseExceptionHandler("/Home/Error"); //Proje production kýsmýnda hata olursa buraya git
                app.UseHsts();
            }
            app.UseStatusCodePagesWithReExecute("/Home/StatusCode", "?code={0}");
            //app.UseStatusCodePagesWithRedirects("/Home/StatusCode?code={0}");

            app.UseRouting();
            app.UseStaticFiles();
            IdentityIntilazer.SeedData(userManager, roleManager).Wait();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area}/{controller=Home}/{action=Index}/{id?}"

                    );


                endpoints.MapControllerRoute(

                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"

                    );
            });
        }
    }
}
