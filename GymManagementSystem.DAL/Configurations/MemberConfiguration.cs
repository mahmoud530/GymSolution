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
    internal class MemberConfiguration : GymUserConfiguration<Member> , IEntityTypeConfiguration<Member>
    {
        //7atet new hna 3l4an my3mlsh dublicat l2n hwa mawgod f el gymmConfiguration
        public new void configure(EntityTypeBuilder<Member> builder)
        {

            
   

            builder.Property(X => X.CreatedAt)
             .HasColumnName("JoinDate")
             .HasDefaultValueSql("GETDATE() ");

            // hna b2a hast5db de 3la4an a2olo ro7 ll GymUSerConfiguration 3l4an y3ml configure ll properties elly mwgoda f el GymUser
            base.Configure(builder);
        }

    }
}
