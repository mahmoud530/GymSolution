using GymManagementSystem.DAL.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL.Models
{
    //da msh entity da helper ba7ot feh el 7agat ek common bs 
    public class GymUser : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public DateOnly DateOfBirth { get; set; } 
        public Gender Gender { get; set; } 
        public Address Address { get; set; } = default!;

    }
    //leh 3amlna da ? ,77thomsh f el class zai fo2 leh ? 
    [Owned]
    public class Address
    {
        public string BuildingNumber { get; set; } = default!;
        public string Street { get; set; } = default!;
        public string City { get; set; } = default!;
    }
}
