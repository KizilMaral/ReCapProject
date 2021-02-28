using Core.DataAccsess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFrameWork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RCProjectCarDatabaseContext>, ICarDal
    {/*
        public void Add(Car entitiy)
        {
            using (RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                var addedEntity = context.Entry(entitiy);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entitiy)
        {
            using (RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                var deletedEntity = context.Entry(entitiy);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> Filter = null)
        {
            using (RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                return context.Set<Car>().SingleOrDefault(Filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> Filter = null)
        {
            using (RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                return Filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(Filter).ToList();
            }
        }

        public void Update(Car entitiy)
        {
            using (RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                var ChangedEntitiy = context.Entry(entitiy);
                ChangedEntitiy.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        */
        public List<CarDetailDto> GetCarDetails()
        {
            using(RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join co in context.Colors on c.ColorId equals co.ColorId
                             select new CarDetailDto {DetailId = c.Id, CarName = c.CarName + " " + c.ModelYear, BrandName = b.BrandName, ColorName = co.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
