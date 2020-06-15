using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Base
{
    public abstract class ValueObject<TKey> : IValueObject<TKey> where TKey:new()
    {
        public ValueObject()
        {
            KeyValue = new TKey();
        }

        public TKey KeyValue { get; set; }
    }
}
