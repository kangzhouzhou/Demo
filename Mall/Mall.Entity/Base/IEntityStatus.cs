using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Entity.Base
{
    /// <summary>
    /// 实体基本状态
    /// </summary>
    public interface IEntityStatus
    {
        public EntityStatus EntityStatus { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime DeleteTime { get; set; }
    }
}
