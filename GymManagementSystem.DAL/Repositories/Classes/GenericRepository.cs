using GymManagementSystem.DAL.Models;
using GymManagementSystem.DAL.Repositories.Interfaces;
using GymMVC.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL.Repositories.Classes
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity, new()
    {

        //database connection
        private readonly GymDbContext _dbContext;
        private readonly DbSet<TEntity> _set;

        public GenericRepository(GymDbContext dbContext)
        {
            _dbContext = dbContext;
            _set = _dbContext.Set<TEntity>();
           // b3d de a3ml el register f el program service
           // m3 el 3elm en el geraic leh tare2a register mo5talfa (Type of )

        }
        public async Task<int> AddAsync(TEntity entity)
        {
            _set.Add(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(TEntity entity)
        {
            _set.Remove(entity);
            return await _dbContext.SaveChangesAsync();

        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(bool tracking = false, CancellationToken ct = default)
        {
            //msh fahem da w el tracking 
            IQueryable<TEntity> query = tracking ? _set : _set.AsNoTracking();
            return await query.ToListAsync();

        }

        public async Task<TEntity?> GetByIdAsync(int id, CancellationToken ct = default)
        
            //msh fahem de 
            => await _set.FindAsync(id, ct);

       

        public async Task<int> UpdateAsync(TEntity entity)
        {
            _set.Update(entity);
            return await _dbContext.SaveChangesAsync();


        }
    }
}
