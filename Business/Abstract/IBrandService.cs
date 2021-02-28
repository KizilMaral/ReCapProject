using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResults Add(Brand brand);
        IResults Update(Brand brand);
        IResults Delete(Brand brand);
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetByBrandİd(int id);
       





    }
}
