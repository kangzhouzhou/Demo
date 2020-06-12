using Mall.Dto.Base;
using Mall.Dto.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Application
{
    /// <summary>
    /// 身份服务
    /// </summary>
    public interface IdentityService
    {
        /// <summary>
        /// 账号登录
        /// </summary>
        /// <param name="requestBody"></param>
        /// <returns></returns>
        ResponseBody<string> Login(LoginPostBody requestBody);

        /// <summary>
        /// 第三方授权
        /// </summary>
        /// <param name="requestBody"></param>
        /// <returns></returns>
        ResponseBody<string> ThirdParty(ThirdPartyPostBody requestBody);
    }
}
