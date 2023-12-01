using Microsoft.AspNetCore.Identity;

namespace IdentityProject.Entities
{
    // Costume Sınıfımızı açtık
    public class MyCostumeUser : IdentityUser <int> // primary key imiz id değeri olacak
    {
        public string ImagePath { get; set; }
        public string Gender { get; set; }
    }
}
