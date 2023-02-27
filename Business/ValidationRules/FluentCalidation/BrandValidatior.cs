using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentCalidation
{
    public class BrandValidatior : AbstractValidator<Brand>
    {
        public BrandValidatior()
        {
            RuleFor(b => b.Id).NotEmpty();
            RuleFor(b => b.Name).NotEmpty();
            RuleFor(b => b.Name).MinimumLength(2);
        }
    }
}
