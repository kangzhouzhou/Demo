using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mall.Aggregate.Base
{
    /// <summary>
    /// 实体
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IEntity<TKey> : IKey<TKey> where TKey:new()
    {
    }
}
