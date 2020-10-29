using Business_Tracking.Business.Abstract;
using Business_Tracking.Business.Concrete;
using Business_Tracking.Business.FluentValidation;
using Business_Tracking.DAL.Context;
using Business_Tracking.DTOs.DTOs;
using Business_Tracking.DTOs.DTOs.AppUserDto;
using Business_Tracking.DTOs.DTOs.JobsDto;
using Business_Tracking.DTOs.DTOs.RaporsDto;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.Repository.Repository.Abstract;
using Business_Tracking.Repository.Repository.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business_Tracking.UI.CustomCollectionExtension
{
    public static class CollectionExtension
    {


        public static void AddIdentity(this IServiceCollection services)
        {

            //Identity Ayarları
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ProjectContext>();

            services.Configure<IdentityOptions>(opt =>
            {
                opt.Password.RequiredLength = 1;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireDigit = false;


            });

            services.ConfigureApplicationCookie(opt =>
            {
                opt.Cookie.Name = "Business";
                opt.Cookie.SameSite = SameSiteMode.Strict; //Başka web sayfasıyla paylaşılmaması için
                opt.Cookie.HttpOnly = true; //Cookie bilgisine ulaşamaz
                opt.ExpireTimeSpan = TimeSpan.FromMinutes(2); //Cookie ne kadar zaman tutulsun
                opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest; //İstek ne ise ona göre davran
                opt.LoginPath = "/Home/Login";



            });




        }


        public static void AddValidator(this IServiceCollection services)
        {

            services.AddTransient<IValidator<UrgencyAddUpdateDto>, UrgencyAddValidation>();
            services.AddTransient<IValidator<JobsAddUpdateDto>, JobsListAddUpdateViewModelValidation>();
            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginValidation>();
            services.AddTransient<IValidator<AppUserRegisterDto>, AppUserRegisterValidation>();
            services.AddTransient<IValidator<RaporsAddViewModel>, RaporAddValidation>();



        }


    }
}
