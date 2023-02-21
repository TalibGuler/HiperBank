using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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

    }
}
