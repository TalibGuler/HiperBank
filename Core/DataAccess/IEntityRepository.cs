using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // generic constraint
    // class : referans tip
    // IEntity : IEntity olabilir ve IEntity implemente eden bir nesne olabilir
    // new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> expression = null);
      //  List<T> GetAll(Expression<Func<T, bool>> expression = null);
        T Get(Expression<Func<T, bool>> expression);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);


    }
}
