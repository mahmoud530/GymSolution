using GymMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL.Models
{
    public class Membership : BaseEntity
    {
        public Member Member { get; set; }
        public int MemberId { get; set; }

        public Plan Plan { get; set; }

        public int PlanId { get; set; }

        //start data and 

        public DateTime EndDate { get; set; }

        //dol prperties msh hay5o4o el DB bs m3rf4 leh ? 
        // el EF core auto lma byla2y el reedonly properties msh byro7 y7wlha ll db as columns
        public string Status => EndDate > DateTime.Now ? "Active" : "Expired";
        public bool IsActive => EndDate > DateTime.Now ;







    }
}
