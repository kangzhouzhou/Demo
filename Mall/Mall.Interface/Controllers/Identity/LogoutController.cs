using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mall.Interface.Controllers.Identity
{
    [Route("Api/Identity/Logout")]
    public class LogoutController : ApiBaseController<LogoutController>
    {
        public LogoutController(ILogger<LogoutController> logger) 
            : base(logger)
        { 
            
        }
    }
}