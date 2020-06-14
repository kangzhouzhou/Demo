using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.IEntity.Base
{
    public interface IEntityEnable
    {
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }
    }
}
