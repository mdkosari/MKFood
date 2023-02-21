using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKFood.DB.Models
{
    internal class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.ToTable("Foods").HasKey(f => f.FoodId);

            builder.Property(f => f.FoodId).ValueGeneratedOnAdd();

            builder.Property(f => f.Name).HasMaxLength(20);

            builder.HasOne(f => f.Category)
                .WithMany(c => c.Foods)
                .HasForeignKey("CategoryId");

            builder.HasMany(f => f.Prices)
                .WithOne(Price => Price.Food);

            builder.Property<DateTime>("LastUpdated");
        }
    }
}
