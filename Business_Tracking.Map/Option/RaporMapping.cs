using Business_Tracking.Entities.ORM.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Map.Option
{
    public class RaporMapping:BaseMapping<Rapor>
    {

        public override void Configure(EntityTypeBuilder<Rapor> builder)
        {

            builder.Property(i => i.Description).HasMaxLength(100).IsRequired();


            builder.HasOne(i => i.Jobs)
                .WithMany(i => i.Rapors)
                .HasForeignKey(i => i.JobsID);

            base.Configure(builder);
        }
    }
}
