using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Mall.Aggregate.Enums
{
    /// <summary>
    /// 登录方式
    /// </summary>
    public enum ClientType
    {
        /// <summary>
        /// None
        /// </summary>
        [Description("全部")]
        None = 0,

        /// <summary>
        /// 账号登录
        /// </summary>
        [Description("账号登录")]
        Account = 1,

        /// <summary>
        /// 微信登录
        /// </summary>
        [Description("微信登录")]
        WeChatApp = 2,

        /// <summary>
        /// 钉钉程序
        /// </summary>
        [Description("钉钉登录")]
        DingTalkApp = 3,

        /// <summary>
        /// 企业微信程序
        /// </summary>
        [Description("企业微信登录")]
        EnterpriseWeChatApp = 4,

        /// <summary>
        /// 验证码登录
        /// </summary>
        [Description("验证码登录")]
        VerificationCode = 5,

    }
}
