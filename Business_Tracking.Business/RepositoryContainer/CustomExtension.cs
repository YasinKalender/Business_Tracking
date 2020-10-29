using Business_Tracking.Business.Abstract;
using Business_Tracking.Business.Concrete;
using Business_Tracking.Business.CustomLogger;
using Business_Tracking.Repository.Repository.Abstract;
using Business_Tracking.Repository.Repository.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Business.RepositoryContainer
{
    public static class CustomExtension
    {

        public static void Add(this IServiceCollection services)
        {

            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IJobsRepository, JobsRepository>();
            services.AddScoped<IJobsService, JobsManager>();
            services.AddScoped<IRaporRepository, RaporRepository>();
            services.AddScoped<IRaporService, RaporManager>();
            services.AddScoped<IUrgencyRepository, UrgencyRepository>();
            services.AddScoped<IUrgencyService, UrgencyManager>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<INotificationService, NotificationManager>();


            services.AddTransient<ICustomLogger, NLogLogger>();


        }

    }
}
