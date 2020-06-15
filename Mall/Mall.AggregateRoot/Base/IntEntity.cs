using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Base
{
    public class IntEntity : Entity<int>
    {
        public int Id { get { return KeyValue; } set { KeyValue = value; } }
    }
}
