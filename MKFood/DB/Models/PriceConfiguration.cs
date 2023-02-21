using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKFood.DB.Models
{
    internal class PriceConfiguration : IEntityTypeConfiguration<Price>
    {
        public void Configure(EntityTypeBuilder<Price> builder)
        {
            builder.ToTable("Prices").HasKey(p => p.PriceId);

            builder.Property(p => p.PriceId).ValueGeneratedOnAdd();

            builder.HasOne(p => p.Food).WithMany(f => f.Prices).HasForeignKey("FoodId");

            builder.Property<DateTime>("LastUpdated");

        }
    }
}
