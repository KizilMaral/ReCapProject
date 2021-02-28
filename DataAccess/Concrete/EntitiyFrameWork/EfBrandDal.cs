using Core.DataAccsess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFrameWork
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RCProjectCarDatabaseContext>,IBrandDal
    {
        /*
        public void Add(Brand entitiy)
        {
            using (RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                var addedEntity = context.Entry(entitiy);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entitiy)
        {
            using (RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                var deletedEntity = context.Entry(entitiy);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> Filter = null)
        {
            using (RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                return context.Set<Brand>().SingleOrDefault(Filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> Filter = null)
        {
            using (RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                return Filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(Filter).ToList();
            }
        }

        public void Update(Brand entitiy)
        {
            using (RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                var ChangedEntitiy = context.Entry(entitiy);
                ChangedEntitiy.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        */
    }
}
