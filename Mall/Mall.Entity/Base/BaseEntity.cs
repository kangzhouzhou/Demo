using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Entity.Base
{
    public abstract class BaseEntity : IEntityStatus
    {
        public EntityStatus EntityStatus { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime DeleteTime { get; set; }
    }
}
