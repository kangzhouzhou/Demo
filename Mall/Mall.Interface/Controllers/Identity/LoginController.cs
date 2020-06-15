using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mall.Application;
using Mall.Dto.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mall.Interface.Controllers.Identity
{
    [Route("Api/Identity/Login")]
    public class LoginController : ApiBaseController<LoginController>
    {
        public LoginController(IdentityService service,ILogger<LoginController> logger)
            :base(logger)
        {  
            
        }

        [HttpPost]
        public string Post([FromBody]LoginPostBody requestBody)
        {
            return "1";
        }
    }
}