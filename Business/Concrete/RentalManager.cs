using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var result = CheckIfCarReady(rental);
            if(result.Success)
                _rentalDal.Add(rental);
            return result;
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<Rental> Get(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailsByCarId(int carId)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails().Where(r => r.CarId == carId).ToList());
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailsByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails().Where(r => r.CustomerId == customerId).ToList());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }

        private IResult CheckIfCarReady(Rental rental)
        {
            var result = _rentalDal.GetAll(p => p.CarId == rental.CarId).Where(t => t.ReturnDate == null).ToList();
            if (result.Any())
            {
                return new ErrorResult("Araç daha önce kiralandı");
            }

            return new SuccessResult();
        }
    }
}
