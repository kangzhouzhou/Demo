using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Mall.IEntity.Enums
{
    /// <summary>
    /// 登录设备
    /// </summary>
    public enum LoginDevice
    {
        [Description("")]
        None = 0,

        [Description("移动设备")]
        Mobile = 1,

        /// <summary>
        /// 电脑
        /// </summary>
        [Description("电脑")]
        Computer = 2,
    }
}
