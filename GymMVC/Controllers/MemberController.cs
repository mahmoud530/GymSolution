using GymManagementSystem.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GymManagementSystem.PL.Controllers
{
    public class MemberController : Controller
    {
        //member service 
        private readonly IMemberService _memberService;
            public MemberController(IMemberService memberService)       {
             _memberService = memberService;
        }

        #region GET Members
        //GET :: url/members/index list of all members 
        public async Task<IActionResult> Index(CancellationToken ct)
        {
            //call service = get all members
            var members = await _memberService.GetAllAsync(ct);
            return View(members);
        }
        //GET :: url/members/Details {id} get 1 member
        //GET :: url/members/HealthRecordDetails/{id} get health details for 1 member 

        #endregion

        #region Create
        //GET :: url/members/create show empty form 
        //Post :: url/members/create/{member} submit form  

        #endregion

        #region Edit
        //GET :: url/members/Edit/{id} show edit form 
        //POST :: url/members/Edit/{member} Submit edit form 
        #endregion

        #region Delete
        //GET :: url/members/delete/{id} show validation page (poup)
        #endregion






    }
}
