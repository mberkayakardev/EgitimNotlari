using System.ComponentModel.DataAnnotations;

namespace IdentityProject.Models
{
    public class CreateUserDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }

    }
}
