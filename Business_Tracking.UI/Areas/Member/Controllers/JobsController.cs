using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business_Tracking.Business.Abstract;
using Business_Tracking.DTOs.DTOs.JobsDto;
using Business_Tracking.DTOs.DTOs.RaporsDto;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.UI.BaseControllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Business_Tracking.UI.Areas.Member.Controllers
{

    [Area("Member")]
    public class JobsController : BaseController
    {

        private IJobsService _jobsService;
        private IMapper _mapper;
        private IRaporService _raporService;
        private INotificationService _notificationService;
        public JobsController(UserManager<AppUser> userManager, IJobsService jobsService, IMapper mapper, IRaporService raporService, INotificationService notificationService):base(userManager)
        {

            _jobsService = jobsService;
            _mapper = mapper;
            _raporService = raporService;
            _notificationService = notificationService;
        }


        public async Task<IActionResult> Index()
        {
            var user = await GirisYapanKullanici();




            return View(_mapper.Map<List<JobsListDto>>(_jobsService.WithWork(user.Id)).ToList());
        }

        public IActionResult AddRapor(int id)
        {
            var job = _jobsService.WithUrgency(id);

            RaporsAddViewModel model = new RaporsAddViewModel();
            model.JobsID = id;
            model.Jobs = job;


            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> AddRapor(RaporsAddViewModel model)
        {

            if (ModelState.IsValid)
            {

                _raporService.Add(new Rapor()
                {

                    Description = model.Description,
                    Details = model.Details,
                    JobsID = model.JobsID


                });
                var user = await GirisYapanKullanici();
                var roller = await _userManager.GetUsersInRoleAsync("Admin");

                foreach (var item in roller)
                {
                    _notificationService.Add(new Notification()
                    {

                        Description=$"{user.UserName} kişisi yeni bir rapor yazdı",
                        AppUserID=item.Id
                        

                    });
                }

                return RedirectToAction("Index");

            }


            return View(model);
        }

        public IActionResult UpdateRapor(int id)
        {

            var rapor = _raporService.WithJob(id);
            RaporsAddViewModel model = new RaporsAddViewModel();
            model.ID = rapor.ID;
            model.Details = rapor.Details;
            model.Description = rapor.Description;
            model.JobsID = model.JobsID;
            model.Jobs = rapor.Jobs;

            return View(model);
        }


        [HttpPost]
        public IActionResult UpdateRapor(RaporsAddViewModel rapor)
        {
            var urapor = _raporService.GetByid(rapor.ID);
            if (ModelState.IsValid)
            {

                urapor.Description = rapor.Description;
                urapor.Details = rapor.Details;

                _raporService.Update(urapor);

                return RedirectToAction("Index");
            }


            return View(rapor);
        }


     


        public async Task<IActionResult> EndDuty(int id)
        {
            var jobs = _jobsService.GetByid(id);
            jobs.status = Business_Tracking.Entities.ORM.Enum.Status.Passive;
            _jobsService.Update(jobs);


            var roles = await _userManager.GetUsersInRoleAsync("Admin");
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            foreach (var item in roles)
            {
                _notificationService.Add(new Notification()
                {

                    Description=$"{user.FirstName}, {jobs.Description} görevini bitirmiştir",
                    AppUserID=item.Id


                });
            }


            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EndDutyList(int activepage=1)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            int sumpage;
            var jobs = _jobsService.EndDuty(out sumpage, user.Id, activepage);

            ViewBag.sumpage = sumpage;
            ViewBag.activepage = activepage;


            return View(jobs);
        }


       
    }
}
