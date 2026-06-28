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
    internal class BookingConfugration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.Ignore(X => X.Id);
            builder.Property(X => X.CreatedAt)
           .HasColumnName("BookingDate")
           .HasDefaultValueSql("GETDATE()");
            builder.HasKey(X => new {X.SessionId, X.MemberId}); // compisiite key el etnen PK w msh hay5sl tekrar yb2a mara wa7da bs 
        }
    }
}
