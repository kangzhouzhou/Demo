using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Enums
{
    public enum CustomerRole
    {
        None=0,

        /// <summary>
        /// 部门员工
        /// </summary>
        Staff=1,

        /// <summary>
        /// 部门领导
        /// </summary>
        Hard=2
    }
}
