using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Dto.Base
{
    /// <summary>
    /// 错误处理方式
    /// </summary>
    public enum ErrProcess
    {
        /// <summary>
        /// 忽略错误
        /// </summary>
        Ignore = 0,

        /// <summary>
        ///信息提示
        /// </summary>
        InfoTips = 1,

        /// <summary>
        /// 跳转到登录页
        /// </summary>
        ToLogin = 2,

        /// <summary>
        /// 刷新列表
        /// </summary>
        RefreshList = 4,
    }
}
