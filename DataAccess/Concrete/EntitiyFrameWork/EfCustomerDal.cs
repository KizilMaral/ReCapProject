using Entities.Concrete;
using Core.DataAccsess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntitiyFrameWork
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer,RCProjectCarDatabaseContext>,ICustomerDal
    {
    }
}
