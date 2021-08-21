using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            this._rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            BusinessRules.Run(CheckIfCarRentalStatus(rental), CheckIfDeneme(rental));

            _rentalDal.Add(rental);

            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == id));
        }

        private IResult CheckIfCarRentalStatus(Rental rental)
        {
            var deneme = _rentalDal.GetAll();

            foreach (var item in deneme)
            {
                if (rental.CarId == item.CarId)
                {
                    if (item.ReturnDate > rental.RentDate)
                    {
                        return new ErrorResult(Messages.RentalError);
                    }
                }
            }
            return new SuccessResult();
        }

        private IResult CheckIfDeneme(Rental rental)
        {
            var deneme = _rentalDal.GetAll(r => r.CarId == 11).Any();

            if (deneme)
            {
                return new ErrorResult("Bu araba kiralanamaz.");
            }
            return new SuccessResult();
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }
    }
}