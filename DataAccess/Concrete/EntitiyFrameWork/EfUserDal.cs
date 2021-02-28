using Core.DataAccsess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFrameWork
{
   public  class EfUserDal:EfEntityRepositoryBase<User,RCProjectCarDatabaseContext>,IUserDal
    {
    }
}
