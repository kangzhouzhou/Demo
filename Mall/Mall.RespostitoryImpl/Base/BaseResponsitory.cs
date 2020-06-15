using Mall.Persistent;
using Mall.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MMall.RespositoryImpl.Base
{
    /// <summary>
    /// 仓储
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Responsitory<T> : IResponsitory<T> where T : class, new()
    {
        protected IPersistent<T> _persistent;

        public T Get(object key)
        {
            return _persistent.Get(key);
        }

        public IEnumerable<T> GetAll()
        {
            return _persistent.GetAll();
        }

        public void Update(T entity)
        {
            _persistent.Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entityCollection)
        {
            _persistent.UpdateRange(entityCollection);
        }

        public void Remove(T entity)
        {
            _persistent.Remove(entity);
        }

        public void Remove(object key)
        {
            _persistent.Remove(key);
        }

        public void RemoveRange(IEnumerable<T> entityCollection)
        {
            _persistent.RemoveRange(entityCollection);
        }

        public void Add(T entity)
        {
            _persistent.Add(entity);
        }

        public void AddRange(IEnumerable<T> entityCollection)
        {
            _persistent.AddRange(entityCollection);
        }

        public bool SaveChanges()
        {
            return _persistent.SaveChanges();
        }
    }
}
