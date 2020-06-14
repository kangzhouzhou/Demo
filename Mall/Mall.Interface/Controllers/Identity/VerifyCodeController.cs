using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mall.Dto.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mall.Interface.Controllers.Identity
{
    [Route("api/Identity")]
    [ApiController]
    public class VerifyCodeController : ApiBaseController<VerifyCodeController>
    {
        public VerifyCodeController(ILogger<VerifyCodeController> logger) 
            : base(logger)
        {
        }

        [HttpGet("SendPhoneLoginCode")]
        public IActionResult Get(VerifyCodeGetBody requestBody)
        {
            return null;
        }

        [HttpPost("LoginPhone")]
        public IActionResult Post(VerifyCodePostBody requestBody)
        {
            return null;
        }

    }
}