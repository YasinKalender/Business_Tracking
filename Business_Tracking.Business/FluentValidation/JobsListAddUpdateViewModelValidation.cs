using Business_Tracking.DTOs.DTOs.JobsDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Business.FluentValidation
{
    public class JobsListAddUpdateViewModelValidation:AbstractValidator<JobsAddUpdateDto>
    {

        public JobsListAddUpdateViewModelValidation()
        {
            RuleFor(i => i.Name).NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(i => i.Description).MaximumLength(100).WithMessage("En fazla 100 karakter girebilirsiniz");
            
        }

    }
}
