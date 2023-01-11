using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x=> x.Name).NotEmpty().WithMessage("Ad boş geçilemez");
            RuleFor(x=> x.Surname).NotEmpty().WithMessage("Soyad boş geçilemez");
            RuleFor(x=> x.Mail).NotEmpty().WithMessage("Mail boş geçilemez");
            RuleFor(x=> x.UserName).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez");
            RuleFor(x=> x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x=> x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrarı boş geçilemez");

            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler birbiriyle uyuşmuyor");
        }
    }
}
