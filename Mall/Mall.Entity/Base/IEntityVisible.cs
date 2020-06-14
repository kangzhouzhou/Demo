using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.IEntity.Base
{
    public interface IEntityVisible
    {
        /// <summary>
        /// 是否可见
        /// </summary>
        public bool  IsVisible  { get; set; }
    }
}
