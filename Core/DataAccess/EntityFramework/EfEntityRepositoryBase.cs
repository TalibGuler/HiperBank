using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly DbContext context;

        public EfEntityRepositoryBase(DbContext context)
        {
            this.context = context;
        }

        public TEntity Add(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = context.Entry(entity);
            entityEntry.State = EntityState.Added;
            context.SaveChanges();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = context.Entry(entity);
            entityEntry.State = EntityState.Modified;
            context.SaveChanges();
            return entity;
        }

        public void Delete(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = context.Entry(entity);         
            entityEntry.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            return context.Set<TEntity>().SingleOrDefault(expression);
        }

       

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression = null)
        {
            IQueryable<TEntity> result;
            if (expression != null)
            {
                result = context.Set<TEntity>().Where(expression);
            }
            else
            {
                IQueryable<TEntity> queryable = context.Set<TEntity>();
                result = queryable;
            }

            return result;
        }

        //public Task<TEntity> GetAsyncAsNoTracking(Expression<Func<TEntity, bool>> expression)
        //{
        //    throw new NotImplementedException();
        //}

        //public TResult InTransaction<TResult>(Func<TResult> action, Action successAction = null, Action<Exception> exceptionAction = null)
        //{
        //    TResult result = default(TResult);
        //    try
        //    {
        //        if (context.Database.ProviderName.EndsWith("InMemory"))
        //        {
        //            result = action();
        //            context.SaveChanges();
        //        }
        //        else
        //        {
        //            using IDbContextTransaction dbContextTransaction = context.Database.BeginTransaction();
        //            try
        //            {
        //                result = action();
        //                context.SaveChanges();
        //                dbContextTransaction.Commit();
        //            }
        //            catch (Exception)
        //            {
        //                dbContextTransaction.Rollback();
        //                throw;
        //            }
        //        }

        //        successAction?.Invoke();
        //    }
        //    catch (Exception obj)
        //    {
        //        if (exceptionAction == null)
        //        {
        //            throw;
        //        }

        //        exceptionAction(obj);
        //    }

        //    return result;
        //}
    }
}
