using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.UserId).NotEmpty();
            RuleFor(p => p.UserId).GreaterThan(0);
            RuleFor(p => p.CompanyName).NotEmpty();
            RuleFor(p => p.CompanyName).MaximumLength(10).MinimumLength(2);
            RuleFor(p => p.CompanyName).Must(ValidateMethods.DasCapital);
        }
    }
}
