using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Mall.Persistent
{
    public interface IPersistent<T> where T : class
    {
        /// <summary>
        /// 获取指定键的实体
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        T Get(object key);

        /// <summary>
        /// 获取所有实体
        /// </summary>
        /// <returns></returns>
       IEnumerable<T> GetAll();

        /// <summary>
        /// 根据条件查询获取实体
        /// </summary>
        /// <param name="express"></param>
        /// <returns></returns>
        IEnumerable<T> Find(Expression<Func<T, bool>> express);

        /// <summary>
        /// 更新实体,
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// 批量更新实体
        /// </summary>
        /// <param name="entityCollection"></param>
        void UpdateRange(IEnumerable<T> entityCollection);

        /// <summary>
        /// 移除指定实体
        /// </summary>
        /// <param name="entity"></param>
        void Remove(T entity);

        /// <summary>
        /// 根据主键移除实体
        /// </summary>
        /// <param name="key"></param>
        void Remove(object key);

        /// <summary>
        /// 批量移除实体
        /// </summary>
        /// <param name="entityCollection"></param>
        void RemoveRange(IEnumerable<T> entityCollection);

        /// <summary>
        /// 增加实体
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// 批量增加实体
        /// </summary>
        /// <param name="entityCollection"></param>
        void AddRange(IEnumerable<T> entityCollection);

        /// <summary>
        /// 保存更改
        /// </summary>
        /// <returns></returns>
        bool SaveChanges();


    }
}
