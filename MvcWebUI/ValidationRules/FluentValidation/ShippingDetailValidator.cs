using FluentValidation;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator : AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("Adı girmeniz gerekiyor.");
            RuleFor(c => c.FirstName).MinimumLength(2);
            RuleFor(c => c.LastName).NotEmpty();
            RuleFor(c => c.Address).NotEmpty();

            RuleFor(c => c.City).NotEmpty().When(c => c.Age < 18);

            //RuleFor(c => c.FirstName).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
