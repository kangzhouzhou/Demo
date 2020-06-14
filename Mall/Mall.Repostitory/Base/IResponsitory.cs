using Mall.Persistent;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Mall.Repository.Base
{
    /// <summary>
    /// 仓储
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IResponsitory<T> where T : class, new()
    {
        T Get(object key);

        IEnumerable<T> GetAll();

        void Update(T entity);

        void UpdateRange(IEnumerable<T> entityCollection);

        void Remove(T entity);

        void Remove(object key);

        void RemoveRange(IEnumerable<T> entityCollection);

        void Add(T entity);

        void AddRange(IEnumerable<T> entityCollection);

        bool SaveChanges();
    }
}
