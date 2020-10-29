using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Tracking.Business.Abstract;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.Repository.Repository.Abstract;
using Business_Tracking.UI.BaseControllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Business_Tracking.UI.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class NotificationsController : BaseController
    {
        private INotificationService _notificationService;
       

        public NotificationsController(INotificationService notificationService,UserManager<AppUser> userManager):base(userManager)
        {
            _notificationService = notificationService;
           
        }

        public async Task<IActionResult> Index()
        {
            var user = await GirisYapanKullanici();

            return View(_notificationService.NotRead(user.Id).ToList());
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            var notification = _notificationService.GetByid(id);
            notification.status = Entities.ORM.Enum.Status.Passive;
            _notificationService.Update(notification);

            return RedirectToAction("Index");
        }



    }
}
