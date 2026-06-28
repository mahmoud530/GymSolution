using GymManagementSystem.BLL.Services.Interfaces;
using GymManagementSystem.BLL.ViewModels.MemberViewModels;
using GymManagementSystem.DAL.Models;
using GymManagementSystem.DAL.Repositories.Classes;
using GymManagementSystem.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.BLL.Services.Classes
{
    public class MemberService : IMemberService
    {
        //db connection hagebo mn el genaric repo 

        private readonly IGenericRepository<Member> _memberRepo;
        public MemberService(IGenericRepository<Member> memberRepo)
        {
            _memberRepo = memberRepo;
        }
        public async Task<IEnumerable<MemberViewModel>> GetAllAsync(CancellationToken ct)
        {
            var members = await _memberRepo.GetAllAsync(ct: ct);
            if (!members.Any()) return [];

            //member elly gay mn el db 7awlo ll viewmodel 
            List<MemberViewModel> memberVM = new List<MemberViewModel>();
            foreach (var member in members)
            {
               var memberViewModel= new MemberViewModel()
                {
                    Name = member.Name,
                    Phone = member.Phone,
                    Photo = member.Photo,
                    Email = member.Email,
                    Id = member.Id,
                    Gender = member.Gender.ToString()
                };
                memberVM.Add(memberViewModel);

            }
            return memberVM;



        }
    }
}
