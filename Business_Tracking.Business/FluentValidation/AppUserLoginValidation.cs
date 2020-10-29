using Business_Tracking.DTOs.DTOs.AppUserDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Business.FluentValidation
{
    public class AppUserLoginValidation:AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginValidation()
        {
            RuleFor(i => i.username).NotNull().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(i => i.password).NotNull().WithMessage("Parola alanı boş geçilemez");
        }

    }
}
