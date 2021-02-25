﻿using Entities.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty();
            RuleFor(r => r.CustomerId).NotEmpty();
            RuleFor(r => r.RentDate).NotEmpty();
            RuleFor(r => r.ReturnDate).NotEmpty().WithMessage("Teslim tarihi boş bırakılamaz");
            RuleFor(r => r.ReturnDate).Must(ReturnDateNotNull);
        }

        private bool ReturnDateNotNull(DateTime arg)
        {
            if (arg == null)
            {
                return false;
            }
            return true;
        }
    }
}
