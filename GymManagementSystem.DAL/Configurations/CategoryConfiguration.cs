using GymManagementSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Configure properties and relationships for the Category entity here
            builder.Property(X => X.CategoryName)
                .HasColumnType("varchar")
                .HasMaxLength(30);

            builder.Property(X => X.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            //seeding mn el ENUM by using (HasData) method
            
            builder.HasData(
                new Category { Id = 1, CategoryName = "GenralFitness" },
                new Category { Id = 2, CategoryName = "Yoga" },
                new Category { Id = 3, CategoryName = "Boxing" },
                new Category { Id = 4, CategoryName = "CrossFit" }
            );
           
        }
    }
}
