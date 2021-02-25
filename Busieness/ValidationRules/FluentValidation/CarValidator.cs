using Entities.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.CarName).NotEmpty();
        }
    }
}
