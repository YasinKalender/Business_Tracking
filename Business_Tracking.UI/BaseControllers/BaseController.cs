using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Tracking.Entities.ORM.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Business_Tracking.UI.BaseControllers
{
    public class BaseController : Controller
    {
        protected readonly UserManager<AppUser> _userManager;

        public BaseController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        protected async Task<AppUser> GirisYapanKullanici()
        {
          return await _userManager.FindByNameAsync(User.Identity.Name);

        }
       
    }
}
