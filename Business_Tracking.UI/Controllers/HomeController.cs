using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Tracking.Business.Abstract;
using Business_Tracking.DTOs.DTOs.AppUserDto;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.UI.BaseControllers;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Business_Tracking.UI.Controllers
{
    public class HomeController : BaseController
    {

        private readonly SignInManager<AppUser> _signInManager;
        private readonly ICustomLogger _customLogger;

        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ICustomLogger customLogger) :base(userManager)
        {

            _signInManager = signInManager;
            _customLogger = customLogger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {


            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(AppUserRegisterDto model)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    FirstName=model.FirstName,
                    LastName=model.LastName,
                    UserName=model.username,
                    Email=model.email


                };

                var result = await _userManager.CreateAsync(appUser, model.password);

                if (result.Succeeded)
                {
                    var roleresult = await _userManager.AddToRoleAsync(appUser, "Member");
                    if (roleresult.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (var item in roleresult.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }

                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }


            }

            return View(model);
        }

        public IActionResult Login()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AppUserLoginDto model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.username);
                if (user!=null)
                {
                   var identityresult= await _signInManager.PasswordSignInAsync(user, model.password, model.rememberMe, false);

                    if (identityresult.Succeeded)
                    {
                        var role = await _userManager.GetRolesAsync(user);

                        if (role.Contains("Admin"))
                        {
                            return RedirectToAction("Index", "Home",new { area="Admin"});
                        }

                        else
                        {
                            return RedirectToAction("Index", "Home",new {area="Member" });
                        }

                    }


                }

                ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlıştır");


            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index");
        }


        public IActionResult StatusCode(int? code)
        {
            

            if (code==404)
            {
                ViewBag.code = code;
                ViewBag.mesaj = "Sayfa Bulunamadı";
            }


            return View();
        }

        public IActionResult Error()
        {

            var exceptionHandler =HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            _customLogger.LogError($"Hata yeri{exceptionHandler.Path} Hata mesajı:{exceptionHandler.Error.Message} Stack:{exceptionHandler.Error.StackTrace}");

            ViewBag.hata = exceptionHandler.Path;
            ViewBag.mesaj = exceptionHandler.Error.Message;

            return View();
        }


        public void Hata()
        {


            throw new Exception("Bu bir hata");
        }

    }
}
