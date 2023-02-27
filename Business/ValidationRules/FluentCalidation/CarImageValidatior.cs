using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentCalidation
{
    public class CarImageValidatior : AbstractValidator<CarImage>
    {
        public CarImageValidatior()
        {
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.CarId).NotEmpty();
            RuleFor(c => c.ImagePath).NotEmpty();
        }
    }
}
