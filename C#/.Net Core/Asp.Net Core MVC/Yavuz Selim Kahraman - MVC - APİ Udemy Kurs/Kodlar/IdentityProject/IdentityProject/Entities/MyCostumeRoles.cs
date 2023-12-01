using Microsoft.AspNetCore.Identity;
using System;

namespace IdentityProject.Entities
{
    public class MyCostumeRoles : IdentityRole<int> // bu bir rol olduğu için ve pk miz int
    {
        public bool IsActive { get; set; }
        public string LongDescription { get; set; } // böyle bişey eklemek istedim.
        public DateTime Credate { get; set; }
    }
}
