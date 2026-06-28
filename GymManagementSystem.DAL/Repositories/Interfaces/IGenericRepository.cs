using GymManagementSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity , new()
    {
        //get by id 
        Task<TEntity?> GetByIdAsync(int id, CancellationToken ct=default);
        //add
        Task<int> AddAsync(TEntity entity);

        //update
        Task<int> UpdateAsync(TEntity entity);
        //delete 
        Task<int> DeleteAsync(TEntity entity);
        //get all 
        Task<IEnumerable<TEntity>> GetAllAsync(bool tracking = false , CancellationToken ct = default  );
        //lma b3ml get b7ot el entity gawa el task 
        //lw add or update or delete b7ot el int gwa el task 
    }
}
