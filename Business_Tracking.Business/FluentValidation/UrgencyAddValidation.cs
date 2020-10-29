using Business_Tracking.DTOs.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Business.FluentValidation
{
    public class UrgencyAddValidation:AbstractValidator<UrgencyAddUpdateDto>
    {
        public UrgencyAddValidation()
        {
            RuleFor(i => i.Name).NotNull().WithMessage("Bu alan boş geçilemez");
        }

    }
}
