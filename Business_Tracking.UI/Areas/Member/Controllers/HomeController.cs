using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Tracking.Business.Abstract;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.UI.BaseControllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Business_Tracking.UI.Areas.Member.Controllers
{

    [Area("Member")]
    public class HomeController : BaseController
    {

        private IRaporService _raporService;
        private IJobsService _jobsService;
        private INotificationService _notificationService;


        public HomeController(UserManager<AppUser> userManager, IRaporService raporService, IJobsService jobsService, INotificationService notificationService):base(userManager)
        {

            _raporService = raporService;
            _jobsService = jobsService;
            _notificationService = notificationService;
        }

        public async Task<IActionResult> Index()
        {
            var user =await GirisYapanKullanici();

            ViewBag.rapor = _raporService.SumRapor(user.Id);
            ViewBag.jobs = _jobsService.SumJobs(user.Id);
            ViewBag.notjobs = _jobsService.SumNotJobs(user.Id);
            ViewBag.notifications = _notificationService.NotRead(user.Id).Count();


            return View();
        }
    }
}
