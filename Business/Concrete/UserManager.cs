﻿using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Business.Concrete
{
    public class UserManager:IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResults Add(User entity)
        {


           
            _userDal.Add(entity);
            return new SuccessResult(Messages.CarAdded);
            
        }

        public IResults Delete(User entity)
        {
            _userDal.Delete(entity);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.ColorsListed);
        }

        public IDataResult<User> GetByUserİd(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.Id == id), Messages.ColorsListed);
        }

        public IResults Update(User entity)
        {
            _userDal.Update(entity);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
