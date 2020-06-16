using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Mall.Application;
using Mall.Dto.Base;
using Mall.Dto.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Mall.Interface.Controllers.Identity
{
    [Route("Api/Identity/Login")]
    public class LoginController : ApiBaseController<LoginController>
    {
        public LoginController(IdentityService identityService, ILogger<LoginController> logger, IConfiguration cc)
            :base(logger)
        {
            _identityService = identityService;
        }

        private readonly IdentityService _identityService;

        [HttpPost]
        public ResponseBody<string> Post([NotNull][FromBody]LoginPostBody requestBody)
        {
            return _identityService.Login(requestBody);
        }
    }
}