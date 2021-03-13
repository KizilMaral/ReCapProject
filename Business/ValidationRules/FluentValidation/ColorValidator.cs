using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(p => p.ColorName).NotEmpty();
            RuleFor(p => p.ColorName).MaximumLength(10).MinimumLength(2);
            RuleFor(p => p.ColorName).Must(ValidateMethods.DasCapital);
        }
    }
}
