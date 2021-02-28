using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResults Add(Rental entity);
        IResults Update(Rental entity);
        IResults Delete(Rental entity);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetByRentalİd(int id);
        IResults CarRetrieve(Rental entity);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
    }
}

