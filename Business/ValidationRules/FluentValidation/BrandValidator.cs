using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(p => p.BrandName).NotEmpty();
            RuleFor(p => p.BrandName).MaximumLength(10).MinimumLength(2);
            RuleFor(p => p.BrandName).Must(ValidateMethods.DasCapital);

        }
    }
}
 