using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mall.Interface.Filters.ActionFilter
{
    public class TTFBFilterAttribute : ActionFilterAttribute
    {
        private readonly ILogger<TTFBFilterAttribute> _logger;

        public TTFBFilterAttribute(ILogger<TTFBFilterAttribute> logger)
        {
            _logger = logger;
        }

    }
}
