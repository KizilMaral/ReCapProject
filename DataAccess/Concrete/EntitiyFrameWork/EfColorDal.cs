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
    public class EfColorDal : EfEntityRepositoryBase<Color, RCProjectCarDatabaseContext>,IColorDal
    {/*
        public void Add(Color entitiy)
        {
            using (RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                var addedEntity = context.Entry(entitiy);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entitiy)
        {
            using (RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                var deletedEntity = context.Entry(entitiy);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> Filter = null)
        {
            using (RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                return context.Set<Color>().SingleOrDefault(Filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> Filter = null)
        {
            using (RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                return Filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(Filter).ToList();
            }
        }

        public void Update(Color entitiy)
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
