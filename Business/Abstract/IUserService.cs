using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResults Add(User user);
        IResults Update(User user);
        IResults Delete(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByUserİd(int id);
    }
}
