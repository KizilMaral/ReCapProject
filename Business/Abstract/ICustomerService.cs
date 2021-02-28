using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResults Add(Customer entity);
        IResults Update(Customer entity);
        IResults Delete(Customer entity);
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetByCustomerİd(int id);
    }
}
