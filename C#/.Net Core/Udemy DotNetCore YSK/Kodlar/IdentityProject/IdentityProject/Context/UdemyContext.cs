using IdentityProject.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityProject.Context
{
    public class UdemyContext : IdentityDbContext<MyCostumeUser, MyCostumeRoles, int>
    {
        // Statup kısmında bizler SQL Server bağlantısı için services içerisinde ilgili conteximizi vereceğiz ve buradan gidecek 
        public UdemyContext(DbContextOptions<UdemyContext> options) : base(options) // dbcontext ten kalıtım alındı.
        {
            
        }
    }
}
