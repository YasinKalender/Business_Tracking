using Business_Tracking.Business.Abstract;
using Business_Tracking.Entities.ORM.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business_Tracking.UI.ViewCompenents
{
    public class Wrapper:ViewComponent
    {
        private UserManager<AppUser> _userManager;
        private INotificationService _notificationService;

        public Wrapper(UserManager<AppUser> userManager, INotificationService notificationService)
        {
            _userManager = userManager;
            _notificationService = notificationService;
        }
        public IViewComponentResult Invoke()
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            ViewBag.notifications = _notificationService.NotRead(user.Id).Count();

            var roles = _userManager.GetRolesAsync(user).Result;

            if (roles.Contains("Admin"))
            {
                return View(user);
            }

            return View("Member",user);
        }

    }
}
