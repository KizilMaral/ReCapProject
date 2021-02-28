using Business.Abstract;
using Business.Constant;
using Core.Utilities;
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
        public IResults Add(Rental entity)
        {
            if(_rentalDal.GetAll(p=>p.CarId == entity.CarId).SingleOrDefault(p=>p.ReturnDate == default/*null*/ ) == default ||  _rentalDal.GetAll().Count == 0  )  
            {
                _rentalDal.Add(entity);
                return new SuccessResult(Messages.RentalAdded);
            }
            return new ErrorResult("Car has'nt been retrieved");
        }

        public IResults CarRetrieve(Rental entity)
        {
            if(entity.ReturnDate == default)
            {
                entity.ReturnDate = DateTime.Now;
                Update(entity);
                return new SuccessResult("Car has been retrieved");
            }
            return new ErrorResult("Car already has retrieved");
            
        }

        public IResults Delete(Rental entity)

        {
            _rentalDal.Delete(entity);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
        }

        public IDataResult<Rental> GetByRentalİd(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.Id == id));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(), Messages.RentalsListed);
        }

        public IResults Update(Rental entity)
        {
            _rentalDal.Update(entity);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
