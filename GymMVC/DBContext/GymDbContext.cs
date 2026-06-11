using GymMVC.Configurations;
using GymMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace GymMVC.DBContext
{
    public class GymDbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=GymDb; Trusted_Connection=true; TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlanConfiguration());
        }


        public DbSet<Plan> Plans { get; set; }


    }
}