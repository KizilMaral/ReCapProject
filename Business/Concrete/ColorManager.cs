using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager:IColorService

    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResults Add(Color entity)
        {
            _colorDal.Add(entity);
            if(entity.ColorName.Length > 2 && entity.ColorName.Length < 8)
            {
                return new SuccessResult(Messages.ColorAdded);
            }
            return new ErrorResult(Messages.ColorNameInvalid);
        }

        public IResults Delete(Color entity)
        {
            _colorDal.Delete(entity);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.ColorsListed);
        }

        public IDataResult<Color> GetByColorİd(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(p => p.ColorId == id),Messages.ColorsListed);
        }

        public IResults Update(Color entity)
        {
            _colorDal.Update(entity);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
