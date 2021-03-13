using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.CarName).NotEmpty();
            RuleFor(p => p.CarName).MaximumLength(10).MinimumLength(2);
            RuleFor(p => p.CarName).Must(ValidateMethods.DasCapital);

            RuleFor(p => p.BrandId).NotEmpty();
            RuleFor(p => p.BrandId).GreaterThan(0);

            RuleFor(p => p.ColorId).NotEmpty();
            RuleFor(p => p.ColorId).GreaterThan(0);

            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);

            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Description).MaximumLength(50).MinimumLength(10);

        }
        
    }
}
