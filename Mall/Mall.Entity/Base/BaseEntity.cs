using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mall.IEntity.Base
{
    public abstract class BaseEntity<T> where T:new()
    {
        public BaseEntity()
        {
            Key = new T();
        }

        [NotMapped]
        public T Key { get; set; }
    }
}
