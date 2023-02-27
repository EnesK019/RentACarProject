using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentCalidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        [ValidationAspect(typeof(CarImageValidatior))]
        public IResult Add(CarImage entity)
        {
            _carImageDal.Add(entity);
            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult Delete(CarImage entity)
        {
            _carImageDal.Delete(entity);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.CarImageListed);
        }

        public IDataResult<CarImage> GetById(int id)
        {
            var result = _carImageDal.Get(c => c.Id == id);
            if(result != null)
            {
                return new SuccessDataResult<CarImage>(result, Messages.CarImageListed);
            }

            return new ErrorDataResult<CarImage>(Messages.CarImageIdInvalid);
        }

        [ValidationAspect(typeof(CarImageValidatior))]
        public IResult Update(CarImage entity)
        {
            _carImageDal.Update(entity);
            return new SuccessResult(Messages.CarImageUpdated);
        }
    }
}
