using GymManagementSystem.BLL.ViewModels.MemberViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.BLL.Services.Interfaces
{
    public interface IMemberService
    {
        //get all 
        Task<IEnumerable<MemberViewModel>> GetAllAsync(CancellationToken ct = default);
    }
}
