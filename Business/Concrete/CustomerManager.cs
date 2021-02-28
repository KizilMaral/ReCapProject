using Business.Abstract;
using Business.Constant;
using Core.Utilities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResults Add(Customer entity)
        {
            if((new EfUserDal().GetAll().SingleOrDefault(p=>p.Id == entity.UserId)) != default)
            {
                return new ErrorResult("Customer is'nt an user");
            }
            _customerDal.Add(entity);
            return new SuccessResult(Messages.CustomerAdded);
        }


        public IResults Delete(Customer entity)
        {
            _customerDal.Delete(entity);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomersListed);
        }

        public IDataResult<Customer> GetByCustomerİd(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.CustomerId == id));
        }

        public IResults Update(Customer entity)
        {
            _customerDal.Update(entity);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
