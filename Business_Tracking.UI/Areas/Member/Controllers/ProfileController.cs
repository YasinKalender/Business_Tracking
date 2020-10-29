using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Business_Tracking.DTOs.DTOs.AppUserDto;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.UI.BaseControllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Business_Tracking.UI.Areas.Member.Controllers
{

    [Area("Member")]
    [Authorize(Roles ="Member")]
    public class ProfileController : BaseController
    {


        public ProfileController(UserManager<AppUser> userManager):base(userManager)
        {
         
        }

        public async Task<IActionResult> Index()
        {
            var user = await GirisYapanKullanici();
            AppUserUpdateDto model = new AppUserUpdateDto();
            model.Id = user.Id;
            model.FirstName = user.FirstName;
            model.LastName = user.LastName;
            model.username = user.UserName;
            model.email = user.Email;
 


            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Index(AppUserUpdateDto model,IFormFile Image)
        {

            var user = _userManager.Users.FirstOrDefault(i => i.Id == model.Id);
            if (ModelState.IsValid)
            {

                if (Image!=null)
                {
                    var pic = Path.GetExtension(Image.FileName);
                    var picname = Guid.NewGuid() + pic;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + picname);

                    using(var stream = new FileStream(path, FileMode.Create))
                    {

                       await stream.CopyToAsync(stream);

                    }

                    user.Image = picname;

                }




                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.UserName = model.username;
                user.Email = model.email;


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
