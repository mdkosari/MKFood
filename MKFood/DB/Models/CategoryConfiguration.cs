using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKFood.DB.Models
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories")
                .HasKey(c => c.CategoryId);

            builder.Property(c => c.CategoryId)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .HasMaxLength(20);

            builder.HasMany(c => c.Foods)
                .WithOne(f => f.Category);

            builder.Property<DateTime>("LastUpdated");

        }
    }
}
