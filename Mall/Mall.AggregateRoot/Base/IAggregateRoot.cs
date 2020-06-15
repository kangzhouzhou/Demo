using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mall.Aggregate.Base
{
    public interface IAggregateRoot<TKey> : IEntity<TKey> where TKey : new()
    {
    }
}
