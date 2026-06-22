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
    //el T da ya3ny ana b2olo Genaric class y3ny ht3amel m3 ay model 3l4an el gymuser da msh entity da helper
    //where T : GymUser (ya3ny b2olo 4a8l el class da lazm ykoun inherited mn GymUser elly home el (member-trainer))
    internal class GymUserConfiguration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(X => X.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(X => X.Email)
                .HasColumnType("varchar")
                .HasMaxLength(100);


            //indexes
            builder.HasIndex(X => X.Email).IsUnique(); 
            builder.HasIndex(X => X.Phone).IsUnique(); 


            //3la el table kolo 

            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint("EmailCheck", "Email LIKE '%@%'");
                tb.HasCheckConstraint("PhoneCheck", "Phone LIKE '010%' or Phone LIKE '011%' or Phone LIKE '012%' or Phone LIKE '015%'");

            
            });
            //addres Owned Entity Type
            //hadelo variable or expression (another paramter) elly hwa => 3l4an lw 3ayez a3dl 3aleh 
            builder.OwnsOne(X=> X.Address ,
                address =>
                { 
                    address.Property(X=> X.Street )
                    .HasColumnName("Street")
                    .HasColumnType("varchar")
                    .HasMaxLength(30);

                    address.Property(X => X.City)
                   .HasColumnName("City")
                   .HasColumnType("varchar")
                   .HasMaxLength(30);
                }
            )


        }
    }
}
