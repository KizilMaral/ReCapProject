using Business.Abstract;
using Business.Constant;
using Core.Aspects.Autofac.Validation;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        } 
        [ValidationAspect(typeof(BrandManager())]
        public IResults Add(Brand brand)
        {
            
                _brandDal.Add(brand);
                return new SuccessResult(Messages.BrandAdded);
            
            
        }

        public IResults Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }

        public IDataResult<Brand> GetByBrandİd(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == id),Messages.BrandsListed);
        }

        public IResults Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
