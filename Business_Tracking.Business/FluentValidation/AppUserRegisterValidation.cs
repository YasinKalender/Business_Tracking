using Business_Tracking.DTOs.DTOs.AppUserDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Business.FluentValidation
{
    public class AppUserRegisterValidation:AbstractValidator<AppUserRegisterDto>
    {

        public AppUserRegisterValidation()
        {
            RuleFor(i => i.username).NotNull().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(i => i.password).NotNull().WithMessage("Parola alanı boş geçilemez");
            //RuleFor(i => i.password).Equal(i => i.password).WithMessage("Parolo alanları eşleşmiyor"); Eğer bir karşılaştırma yaptırmak istiyorsak EQUAL kullanırız
            RuleFor(İ => İ.email).NotNull().WithMessage("Mail alanı boş geçilemez").EmailAddress().WithMessage("Geçersiz email adresi");

        }

    }
}
