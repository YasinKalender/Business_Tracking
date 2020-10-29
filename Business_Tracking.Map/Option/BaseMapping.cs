using Business_Tracking.Entities.ORM.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Map.Option
{
    public class BaseMapping<T>: IEntityTypeConfiguration<T> where T : BaseEntity
    {

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(i => i.ID);
            builder.Property(i => i.AddDate).IsRequired();
            builder.Property(i => i.DeleteDate).IsRequired(false);
            builder.Property(i => i.UpdateDate).IsRequired(false);
            builder.Property(i => i.status).IsRequired();
        }
    }

}
