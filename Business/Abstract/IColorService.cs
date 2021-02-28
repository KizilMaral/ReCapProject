using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResults Add(Color color);
        IResults Update(Color color);
        IResults Delete(Color color);
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetByColorİd(int id);
       
    }
}
