using GymManagementSystem.DAL.Repositories.Classes;
using GymManagementSystem.DAL.Repositories.Interfaces;
using GymMVC.DBContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymMVC.Controllers
{
    public class PlanController : Controller
    {
        
        //field by3br 3n el class da gwah kol 7aga w el connection 
        private readonly IPlanRepository _planRepository;

        public PlanController(IPlanRepository planRepository)

        {
            _planRepository = planRepository;
        }


        // GET: url (plan/Index)
        public async Task<IActionResult> Index(CancellationToken ct)
        {
            var plans = await _planRepository.GetAllPlansAsync(ct : ct  ); //pass by name 
            return View(plans);
        }

        

        public async Task<IActionResult> Details(int id , CancellationToken ct)
        {
            var plan = await _planRepository.GetByIdAsync(id , ct);

            if(plan == null )
            {
                return RedirectToAction("Index");
            }
            return View(plan);
        }


        
    }
}
