using Business_Tracking.Entities.ORM.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Map.Option
{
    public class NotificationMapping : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasKey(i => i.ID);

            builder.Property(i => i.Description).HasMaxLength(200);

            builder.HasOne(i => i.AppUser)
                .WithMany(i => i.Notifications)
                .HasForeignKey(i => i.AppUserID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
