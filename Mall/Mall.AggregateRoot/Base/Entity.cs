﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Base
{
    public abstract class Entity<TKey> : IEntity<TKey> where TKey : new()
    {
        public Entity()
        {
            KeyValue = new TKey();
        }

        public TKey KeyValue { get; set; }
    }
}
