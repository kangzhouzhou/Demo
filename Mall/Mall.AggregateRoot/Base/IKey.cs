using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Base
{
    /// <summary>
    /// 实体键
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IKey<TKey> where TKey : new()
    {
        TKey KeyValue { get; set; }
    }
}
