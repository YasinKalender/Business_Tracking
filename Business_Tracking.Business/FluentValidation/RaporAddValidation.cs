using Business_Tracking.DTOs.DTOs.RaporsDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Business.FluentValidation
{
    public class RaporAddValidation:AbstractValidator<RaporsAddViewModel>
    {

        public RaporAddValidation()
        {
            RuleFor(i => i.Description).NotNull().WithMessage("Tanım alanı boş geçilemez");
            RuleFor(i => i.JobsID).ExclusiveBetween(0, int.MaxValue).WithMessage("Lütfen iş seçiniz");
        }
    }
}
