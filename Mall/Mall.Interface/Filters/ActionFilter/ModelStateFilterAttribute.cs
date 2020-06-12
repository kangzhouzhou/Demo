using Mall.Dto.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mall.Interface.Filters.ActionFilter
{
    /// <summary>
    /// 模型检查过滤器
    /// </summary>
    public class ModelStateFilterAttribute: ActionFilterAttribute
    {
        private readonly ILogger<ModelStateFilterAttribute> _logger;

        public ModelStateFilterAttribute(ILogger<ModelStateFilterAttribute> logger)
        {
            _logger = logger;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            if (!context.ModelState.IsValid)
            {
                ResponseBody response = new ResponseBody();
                response.Err = "参数验证失败";
                response.ErrProcess = ErrProcess.InfoTips;
                context.Result = new JsonResult(response);
            }
        }
    }
}
