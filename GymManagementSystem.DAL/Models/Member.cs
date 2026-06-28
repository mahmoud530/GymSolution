using GymMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL.Models
{
    public class Member : GymUser

    {
        public string? Photo { get; set; }
        //join date = created at of base entiuty
        #region relationships 
        public HealthRecord HealthRecord { get; set; } = default!;

        public ICollection<Membership> Plans { get; set; } = default!;
        public ICollection<Booking> MemberSession { get; set; } = default!;


        #endregion
    }
}
