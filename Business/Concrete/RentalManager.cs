using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var carToRent = _rentalDal.Get(r=>r.CarId == rental.CarId && r.ReturnDate == null);

            if(carToRent == null)
            {
                _rentalDal.Add(rental);

                return new SuccessResult(Messages.RentalAdded);
            }

            return new ErrorResult(Messages.RentalFailed);
        }

        public IResult Update(Rental rental)
        {
            var carRentUpdate = _rentalDal.Get(r => r.CarId == rental.CarId && r.ReturnDate == null);

            if (carRentUpdate != null)
            {
                _rentalDal.Update(rental);

                return new SuccessResult(Messages.RentalUpdated);
            }

            return new ErrorResult(Messages.RentalFailed);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);

            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
        }
    }
}
