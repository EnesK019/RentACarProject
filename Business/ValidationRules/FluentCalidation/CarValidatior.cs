using Core.Aspects.Autofac.Validation;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentCalidation
{
    public class CarValidatior : AbstractValidator<Car>
    {
        public CarValidatior()
        {
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.Description_).NotEmpty();
            RuleFor(c=>c.Description_).MinimumLength(3);
            RuleFor(c => c.Description_).MaximumLength(100);
        }
    }
}
