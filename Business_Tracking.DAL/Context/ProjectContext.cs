using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.Map.Option;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.DAL.Context
{
    public class ProjectContext:IdentityDbContext<AppUser,AppRole,int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Business_Tracking;integrated security=true;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserMapping());
            builder.ApplyConfiguration(new JobsMapping());
            builder.ApplyConfiguration(new UrgencyMapping());
            builder.ApplyConfiguration(new RaporMapping());
            builder.ApplyConfiguration(new NotificationMapping());

            base.OnModelCreating(builder);
        }

        public DbSet<Jobs> Jobs { get; set; }

        public DbSet<Urgency> Urgencies { get; set; }

        public DbSet<Rapor> Rapors { get; set; }


        public DbSet<Notification> Notifications { get; set; }
    }
}
