using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business_Tracking.Business.Abstract;
using Business_Tracking.DTOs.DTOs.JobsDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Business_Tracking.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobsController : Controller
    {
        private IJobsService _jobsService;
        private IMapper _mapper;
        private IUrgencyService _urgencyService;

        public JobsController(IJobsService jobsService, IMapper mapper, IUrgencyService urgencyService)
        {
            _jobsService = jobsService;
            _mapper = mapper;
            _urgencyService = urgencyService;
        }

        public IActionResult Index()
        {
            return View(_mapper.Map<List<JobsListDto>>(_jobsService.WithUrgency()));
        }

        public IActionResult JobsAdd()
        {
            List<SelectListItem> urgency = _urgencyService.GetAll().Select(i => new SelectListItem { Text = i.Name, Value = i.ID.ToString() }).ToList();
            ViewBag.urgency = urgency;

            ViewBag.urgen = new SelectList(_urgencyService.GetAll(), "ID", "Name");

          

            return View();
        }


        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult JobsAdd(JobsAddUpdateDto model)
        {

            if (ModelState.IsValid)
            {

                _jobsService.Add(new Entities.ORM.Concrete.Jobs()
                {
                    Name=model.Name,
                    Description=model.Description,
                    Details=model.Details,
                    UrgencyID=model.UrgencyID
                    


                });

                return RedirectToAction("Index");


            }


            return View(model);
        }

        public IActionResult JobsUpdate(int id)
        {

            var jobs = _mapper.Map<JobsAddUpdateDto>(_jobsService.GetByid(id));
            ViewBag.urgency = new SelectList(_urgencyService.GetAll(), "ID", "Name", jobs);

            return View(jobs);
        }


        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult JobsUpdate(JobsAddUpdateDto model)
        {
            if (ModelState.IsValid)
            {

                _jobsService.Update(new Entities.ORM.Concrete.Jobs()
                {
                    ID=model.ID,
                    Name=model.Name,
                    Description=model.Description,
                    Details=model.Details,
                    UrgencyID = model.UrgencyID


                });

                return RedirectToAction("Index");

            }

            return View(model);
        }

        public IActionResult JobDelete(int id)
        {
            _jobsService.Delete(new Entities.ORM.Concrete.Jobs{ ID = id });

            return Json(null);
        }
    }
}
