using GymMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL.Repositories.Interfaces
{
    public interface IPlanRepository
    {
        //get all plans
        Task<IEnumerable<Plan>> GetAllPlansAsync(bool tracking = false , CancellationToken ct = default);
        //get plan by id
        Task<Plan?> GetByIdAsync(int Id, CancellationToken ct = default);
        //add plan
        Task <int> AddAsync(Plan plan , CancellationToken ct = default);
        //update plan
        Task<int> UpdateAsync(Plan plan, CancellationToken ct = default);
        //delete plan
        Task<int> DeleteAsync(Plan plan, CancellationToken ct = default); 


    }
}
