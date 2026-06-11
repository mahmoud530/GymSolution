using GymMVC.DBContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymMVC.Controllers
{
    public class PlanController : Controller
    {
        //db connection 
        private readonly GymDbContext context;

        public PlanController()
        {
            context = new GymDbContext();
        }
            
        public async Task<IActionResult> Index()
        {
            var plans = await context.Plans.ToListAsync();
            return View(plans);
        }
    }
}
