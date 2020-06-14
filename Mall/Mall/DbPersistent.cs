using Mall.IEntity.Base;
using Mall.Persistent;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Mall.PersistentImpl
{
    public class DbPersistent<T> : IPersistent<T> where T : class
    {
        private DbSet<T> _dbSet;

        private MallDbContext _context;

        public DbPersistent(MallDbContext context)
        {
            context.Database.Migrate();
            _dbSet = context.Set<T>();
        }

        /// <summary>
        /// 获取指定键的实体
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public T Get(object key)
        {
            return _dbSet.Find(key);
        }

        /// <summary>
        /// 获取所有实体
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        /// <summary>
        /// 根据条件查询获取实体
        /// </summary>
        /// <param name="express"></param>
        /// <returns></returns>
        public IEnumerable<T> Find(Expression<Func<T, bool>> express)
        {
            return _dbSet.Where(express);
        }

        /// <summary>
        /// 更新实体,
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        /// <summary>
        /// 批量更新实体
        /// </summary>
        /// <param name="entityCollection"></param>
        public void UpdateRange(IEnumerable<T> entityCollection)
        {
            _dbSet.UpdateRange(entityCollection);
        }

        /// <summary>
        /// 移除指定实体
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        /// <summary>
        /// 根据主键移除实体
        /// </summary>
        /// <param name="key"></param>
        public void Remove(object key)
        {
            T obj = _dbSet.Find(key);
            _dbSet.Remove(obj);
        }

        /// <summary>
        /// 批量移除实体
        /// </summary>
        /// <param name="entityCollection"></param>
        public void RemoveRange(IEnumerable<T> entityCollection)
        {
            _dbSet.RemoveRange(entityCollection);
        }

        /// <summary>
        /// 增加实体
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        /// <summary>
        /// 批量增加实体
        /// </summary>
        /// <param name="entityCollection"></param>
        public void AddRange(IEnumerable<T> entityCollection)
        {
            _dbSet.AddRange(entityCollection);
        }

        /// <summary>
        /// 保存更改
        /// </summary>
        /// <returns></returns>
        public  bool SaveChanges()
        {
            return _context.SaveChanges() != 0;
        }
    }
}
