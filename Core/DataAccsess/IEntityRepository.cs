using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccsess
{
    public interface IEntityRepository<Tentity> where Tentity : class,IEntity,new()
    {
        List<Tentity> GetAll(Expression<Func<Tentity, bool>> Filter = null);
        Tentity Get(Expression<Func<Tentity, bool>> Filter = null);

        void Add(Tentity entity);
        void Update(Tentity entity);
        void Delete(Tentity entity);
        
    }
}
