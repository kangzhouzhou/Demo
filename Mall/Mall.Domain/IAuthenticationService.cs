using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Domain
{
    /// <summary>
    /// 认证服务
    /// </summary>
    public interface IAuthenticationService
    {
        void GetByAccount(string account);
    }
}
