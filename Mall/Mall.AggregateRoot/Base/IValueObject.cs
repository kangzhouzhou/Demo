using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Base
{
    /// <summary>
    /// 值对象
    /// </summary>
    public interface IValueObject<TKey> : IKey<TKey> where TKey : new()
    {

    }
}
