using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mall.Interface.Filters.ActionFilter
{
    /// <summary>
    /// 日志过滤器
    /// </summary>
    public class LogFilterAttribute : ActionFilterAttribute, IFilterMetadata
    {
        private readonly ILogger<LogFilterAttribute> _logger;

        public LogFilterAttribute(ILogger<LogFilterAttribute> logger)
        {
            _logger = logger;
        }
    }
}
