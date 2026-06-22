using GymManagementSystem.DAL.Repositories.Interfaces;
using GymMVC.DBContext;
using GymMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL.Repositories.Classes
{
    public class PlanRepository : IPlanRepository

    {
        //1- DB Connection 
        private readonly GymDbContext dbContext;
        //2- Constructor to inject the DB Context
        public PlanRepository(GymDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //crud operations
        public async Task<int> AddAsync(Plan plan, CancellationToken ct = default)
        {
            dbContext.Plans.Add(plan);
            return await  dbContext.SaveChangesAsync(ct);
        }

        public async Task<int> DeleteAsync(Plan plan, CancellationToken ct = default)
        {
            dbContext.Plans.Remove(plan);
            return await dbContext.SaveChangesAsync(ct);
        }

        public async Task<IEnumerable<Plan>> GetAllPlansAsync(bool tracking = false, CancellationToken ct = default)
        {
            if (tracking)
            {
                return await dbContext.Plans.ToListAsync(ct);
            }
            else
            {
                return await dbContext.Plans.AsNoTracking().ToListAsync(ct);
            }

        }

        public async Task<Plan?> GetByIdAsync(int Id, CancellationToken ct = default)
        {
            return await dbContext.Plans.FindAsync(Id , ct );
        }

        public async Task<int> UpdateAsync(Plan plan, CancellationToken ct = default)
        {
            dbContext.Plans.Update(plan);
            return await dbContext.SaveChangesAsync(ct);
        }
    }
}
