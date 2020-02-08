using AppCore.Data.EF.Extensions;
using AppCore.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.EF.Configurations
{
    class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
        }
    }
}
