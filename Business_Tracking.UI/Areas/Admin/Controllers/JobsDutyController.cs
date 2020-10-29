using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business_Tracking.Business.Abstract;
using Business_Tracking.DTOs.DTOs.AppUserDto;
using Business_Tracking.DTOs.DTOs.JobsDto;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.UI.BaseControllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Business_Tracking.UI.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class JobsDutyController : BaseController
    {
        private IAppUserService _appUserService;
        private IJobsService _jobsService;
        private IMapper _mapper;
        private INotificationService _notificationService;

        public JobsDutyController(IAppUserService appUserService, IJobsService jobsService, IMapper mapper, UserManager<AppUser> userManager, INotificationService notificationService):base(userManager)
        {
            _appUserService = appUserService;
            _jobsService = jobsService;
            _mapper = mapper;
            _notificationService = notificationService;

        }

        public IActionResult Index()
        {
            _appUserService.NotAdmin();

            //Admin olmayan kullanıcıları getirdik
            return View(_mapper.Map<List<JobsListDto>>(_jobsService.AllTables()));
        }

        public IActionResult MissionJob(int id, string s, int page = 1)
        {
            ViewBag.activepage = page; //Sayfalama yapmak için aktif sayfa sayısını aldık
                                       //ViewBag.sumpage = (int)Math.Ceiling((double)_appUserService.NotAdmin().Count()/3); //Toplam sayfa sayısını aldık.3 tane kullanıcı gösrediğim için 3 e böldük ve virgüllü olduğu için bir yukarsındaki math celling fonksiyonunu kullandık



            ViewBag.aranan = s;

            ViewBag.notadmin = _appUserService.NotAdmin(out int sumpage, s, page);


            ViewBag.sumpage = sumpage;//Toplam sayfa sayısını taşıdık



            return View(_mapper.Map<JobsListDto>(_jobsService.WithUrgency(id)));
        }


        [HttpPost]
        public IActionResult MissionJob(AppUserJobsDto model)
        {
            var jobs = _jobsService.GetByid(model.JobsID);
            jobs.AppUserID = model.AppUserID;
            _jobsService.Update(jobs);
            _notificationService.Add(new Notification()
            {
                AppUserID = model.AppUserID,
                Description=$"{jobs.Description} görevi ile görevlendirildiniz"



            });

            return RedirectToAction("Index");

           
        }



        public IActionResult AppUserJobs(AppUserJobsDto model)
        {
            var user = _userManager.Users.FirstOrDefault(i => i.Id == model.AppUserID);

            var jobs = _jobsService.WithUrgency(model.JobsID);

            JobsAppUserListDto userjob = new JobsAppUserListDto();
            userjob.Jobs = jobs;
            userjob.AppUser = user;

            return View(userjob);
        }

        public IActionResult DetailsRapor(int id)
        {
            
            return View(_mapper.Map<JobsListDto>(_jobsService.WithRapor(id)));
        }
    }
}
