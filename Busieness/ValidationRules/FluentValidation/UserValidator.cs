﻿using Entities.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Password).NotEmpty();
        }
    }
}
