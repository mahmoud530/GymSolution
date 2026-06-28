using GymManagementSystem.DAL.Models;
using GymMVC.Configurations;
using GymMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GymMVC.DBContext
{
    public class GymDbContext : DbContext 
    {
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options)
        {
        }
        //hashelo mn hna w a7to fe el 
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.; Database=GymDb; Trusted_Connection=true; TrustServerCertificate=true;");
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


        public DbSet<Plan> Plans { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Session> Sessions { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<HealthRecord> HealthRecords { get; set; }



    }
}