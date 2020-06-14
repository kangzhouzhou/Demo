using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.AggregateRoot
{
    public abstract class BaseEntity: IEntity<int>
    {
        public int Id { get { return Key; } set { Key = value; } }
    }
}
