using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL.Models
{
    public class Session : BaseEntity
    {
     public string Description { get; set; } 
        public int Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate  { get; set; }

        #region relation
        public Trainer Trainer { get; set; }
        //fk
        public int TrainerId { get; set; }

        public Category Category { get; set; }
        //fk
        public int CategoryId { get; set; }

        public ICollection<Booking> SessionMember { get; set; } = default!;


        #endregion


    }
}
