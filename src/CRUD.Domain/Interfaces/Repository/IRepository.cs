using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CRUD.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        TEntity Update(TEntity obj);
        void Remove(Guid id);

        // Any parameter can be placed in arguments expressed in lambda expression
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);

        // SaveChanges is a default method however can be overridden
        int SaveChanges();
    }
}
