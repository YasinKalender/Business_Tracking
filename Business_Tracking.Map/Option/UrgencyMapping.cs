using Business_Tracking.Entities.ORM.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Map.Option
{
    public class UrgencyMapping:BaseMapping<Urgency>
    {
        public override void Configure(EntityTypeBuilder<Urgency> builder)
        {

            builder.Property(i => i.Name).IsRequired();

            builder.HasMany(i => i.Jobs)
                .WithOne(i => i.Urgency)
                .HasForeignKey(i => i.UrgencyID);

         
        }


    }
}
