using Microsoft.AspNetCore.Mvc.Filters;
using NLog;

namespace Sales.Web.Filter
{
    public class ExceptionLoggerFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var logger = LogManager.GetCurrentClassLogger();
            logger.Error(context.Exception);
            //base.OnException(context);
        }
    }
}
