using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Base
{
    public abstract class AggregateRoot<TKey>:IAggregateRoot<TKey> where TKey:new()
    {
        public AggregateRoot()
        {
            KeyValue = new TKey();
        }

        public TKey KeyValue { get; set; }
    }
}
