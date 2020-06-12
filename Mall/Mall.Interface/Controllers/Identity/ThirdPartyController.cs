using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mall.InterfaceDto.Base;
using Mall.InterfaceDto.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mall.Interface.Controllers.Identity
{
    /// <summary>
    /// 身份验证
    /// </summary>
    public class ThirdPartyController : ApiBaseController<ThirdPartyController>
    {
        public ThirdPartyController(ILogger<ThirdPartyController> logger)
            :base(logger)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestBody"></param>
        /// <returns></returns>
        [HttpPost("LoginEnterprise")]
        [AllowAnonymous]
        public ActionResult<ResponseBody<string>> Post([FromBody]ThirdPartyPostBody requestBody)
        {
            return null;
        }
    }
}