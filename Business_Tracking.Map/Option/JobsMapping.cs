using Business_Tracking.Entities.ORM.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Map.Option
{
    public class JobsMapping:BaseMapping<Jobs>
    {

        public override void Configure(EntityTypeBuilder<Jobs> builder)
        {
            builder.Property(i => i.Name).HasMaxLength(100).IsRequired();
            builder.Property(i => i.Description).HasMaxLength(200).IsRequired();

            builder.HasOne(i => i.AppUser)
                .WithMany(i => i.Jobs)
                .HasForeignKey(i => i.AppUserID)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);
        }
    }
}
