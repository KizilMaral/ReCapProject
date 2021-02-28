using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        

        IDataResult<List<Car>> GetAll();
        IResults Add(Car car);
        IResults Update(Car car);
        IResults Delete(Car car);

        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();

    }
}
