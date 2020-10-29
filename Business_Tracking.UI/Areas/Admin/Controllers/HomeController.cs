using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.UI.BaseControllers;
using Business_Tracking.UI.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Business_Tracking.UI.Areas.Admin.Controllers
{   

   [Area("Admin")]
   [Authorize(Roles ="Admin")]
    public class HomeController : BaseController
    {

        public HomeController(UserManager<AppUser> userManager):base(userManager)
        {

        }
    
        public IActionResult Index()
        {
            return View();
        }
    }
}
