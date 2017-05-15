using CRUD.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CRUD.Infra.Data.Context;
using System.Data.Entity;

namespace CRUD.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected CRUDContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(CRUDContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual TEntity Add(TEntity obj)
        {
            var objReturn = DbSet.Add(obj);
            //SaveChanges();

            return objReturn;
        }

        public void Dispose()
        {
            Db.Dispose();
            // Calls Garbage Collector
            GC.SuppressFinalize(this);
        }

        public virtual IEnumerable<TEntity> GetAll() //(int nPages, int skipPages)
        {
            // Pagination 10 in 10 pages: First call will be 'take 10 pages, skip 0'; Second call will be 'take 20 pages, skip 10', and so on.
            // return DbSet.Take(nPages).Skip(skipPages).ToList();
            return DbSet.ToList();
        }

        public virtual TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual void Remove(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
            //SaveChanges();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
        {
            // "predicate" param is a lambda expression already, then it must only be passed as param to where clause.
            return DbSet.Where(predicate);
        }

        public virtual TEntity Update(TEntity obj)
        {
            // EntityFramework doesn't have "update" method, then it must be implemented
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            //SaveChanges();

            return obj;
        }
    }
}
