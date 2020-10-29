using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business_Tracking.Business.Abstract;
using Business_Tracking.DTOs.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Business_Tracking.UI.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class UrgencyController : Controller
    {

        private IUrgencyService _urgencyService;
        private IMapper _mapper;

        public UrgencyController(IUrgencyService urgencyService, IMapper mapper)
        {
            _urgencyService = urgencyService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(_urgencyService.GetAll());
        }

        public IActionResult UrgencyAdd()
        {


            return View();
        }


        [ValidateAntiForgeryToken,HttpPost]
        public IActionResult UrgencyAdd(UrgencyAddUpdateDto model)
        {


            if (ModelState.IsValid)
            {
                _urgencyService.Add(new Entities.ORM.Concrete.Urgency()
                {
                    Name = model.Name

                });

                return RedirectToAction("Index");
            }


            return View(model);
        }

        public IActionResult UrgencyUpdate(int id)
        {
           
           

            return View(_mapper.Map<UrgencyAddUpdateDto>(_urgencyService.GetByid(id)));
        }


        [HttpPost,AutoValidateAntiforgeryToken]
        public IActionResult UrgencyUpdate(UrgencyAddUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _urgencyService.Update(new Entities.ORM.Concrete.Urgency()
                {
                    ID =model.ID,
                    Name=model.Name


                });

                return RedirectToAction("Index");


            }


            return View(model);
        }
    }
}
