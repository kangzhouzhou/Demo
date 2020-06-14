using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mall.AggregateRoot
{
    public abstract class IEntity<T>
    {
        public T Key { get; set; }
    }
}
