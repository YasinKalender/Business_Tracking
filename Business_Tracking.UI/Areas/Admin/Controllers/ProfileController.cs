using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Business_Tracking.DTOs.DTOs.AppUserDto;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.UI.BaseControllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Business_Tracking.UI.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class ProfileController : BaseController
    {


        public ProfileController(UserManager<AppUser> userManager):base(userManager)
        {
            
        }


        public async Task<IActionResult> Index()
        {
            var user =await GirisYapanKullanici();
            AppUserUpdateDto model = new AppUserUpdateDto();
            model.Id = user.Id;
            model.FirstName = user.FirstName;
            model.LastName = user.LastName;
            model.username = user.UserName;
            model.email = user.Email;
            model.Image = user.Image;


            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Index(AppUserUpdateDto model, IFormFile Image)
        {
            var user = _userManager.Users.FirstOrDefault(i => i.Id == model.Id);

            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    string path = Path.GetExtension(Image.FileName);
                    string image = Guid.NewGuid() + path;
                    string pathimage = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + image);


                    using (var stream = new FileStream(pathimage, FileMode.Create))
                    {

                        await stream.CopyToAsync(stream);

                    };

                    user.Image = image;
                }


                user.Id = model.Id;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Email = model.email;
                user.UserName = model.username;

                var identityresult = await _userManager.UpdateAsync(user);

                if (identityresult.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                else
                {
                    foreach (var item in identityresult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }


            }




            return View(model);
        }
    }
}
