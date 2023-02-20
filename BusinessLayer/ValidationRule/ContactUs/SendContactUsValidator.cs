﻿using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule.ContactUs
{
    public class SendContactUsValidator:AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("İçerik alanı boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");


            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu alanına en az 5 karakter veri girişi olmalı.");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu alanına en fazla 100 karakter veri girişi olmalı.");
            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("Mail alanına en az 5 karakter veri girişi olmalı.");
            RuleFor(x => x.Mail).MaximumLength(100).WithMessage("Mail alanına en fazla 100 karakter veri girişi olmalı.");
        } 
    }
}
