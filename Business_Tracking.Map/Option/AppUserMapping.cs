using Business_Tracking.Entities.ORM.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Map.Option
{
    public class AppUserMapping : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(i => i.Id);
            builder.HasMany(i => i.Jobs)
                .WithOne(i => i.AppUser)
                .HasForeignKey(i => i.AppUserID);
                
        }
    }
}
