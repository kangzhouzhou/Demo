using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mall.Interface.Controllers
{
    [ApiController]
    public class ApiBaseController<T> : ControllerBase
    {
        protected ILogger<T> _logger;
        public ApiBaseController(ILogger<T> logger)
        {
            _logger = logger;
        }
    }
}