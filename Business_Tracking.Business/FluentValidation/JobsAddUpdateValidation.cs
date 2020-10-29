using Business_Tracking.DTOs.DTOs.JobsDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Business.FluentValidation
{
    public class JobsAddUpdateValidation : AbstractValidator<JobsAddUpdateDto>
    {
        public JobsAddUpdateValidation()
        {
            RuleFor(i => i.Name).NotNull().WithMessage("İş alanı boş geçilemez");
            RuleFor(i => i.UrgencyID).ExclusiveBetween(0, int.MaxValue).WithMessage("Lütfen bir aciliyet durumu seçiniz");
            //Yabancıl anahtar için kullanır




        }


    }
}
