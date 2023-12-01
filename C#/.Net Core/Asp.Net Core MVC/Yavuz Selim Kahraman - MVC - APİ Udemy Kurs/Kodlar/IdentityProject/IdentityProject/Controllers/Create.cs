using IdentityProject.Entities;
using IdentityProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityProject.Controllers
{
    public class Create : Controller
    {
        // UserManager, RoleManager, SıngInManager
        private readonly UserManager<MyCostumeUser> _user;
        public Create(UserManager<MyCostumeUser> user)
        {
            this._user = user;
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDto CreatedUser)
        {
            if (ModelState.IsValid)
            {
                var costumer = new MyCostumeUser();
                costumer.UserName = CreatedUser.UserName;
                costumer.Gender = CreatedUser.Gender;
                costumer.Email = CreatedUser.Email;
                
                var status = await _user.CreateAsync(costumer,CreatedUser.Password);
                if (status.Succeeded)
                {
                    TempData["Mesaj"] = "Kayıt işlemi başarılı";
                    return RedirectToAction(actionName: "Index", controllerName: "Home");
                }
                else
                {
                    TempData["Mesaj"] = "Bir Hata Oluştu "+status.Errors.FirstOrDefault();
                    return View(CreatedUser);
                }
            }
            return View(CreatedUser);
        }
    }
}
