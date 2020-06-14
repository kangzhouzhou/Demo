using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.IEntity.Base
{
    public abstract class IntEntity : BaseEntity<int>
    {
        public int Id { get { return Key; } set { Key = value; } }
    }
}
