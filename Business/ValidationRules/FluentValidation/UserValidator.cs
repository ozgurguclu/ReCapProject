﻿using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.Email).NotEmpty();
            RuleFor(p => p.Email).Must(MailCheck).When(p => p.Email != null).WithMessage("Invalid mail");
        }

        private bool MailCheck(string arg)
        {
            return arg.Contains("@");
        }
    }
}
