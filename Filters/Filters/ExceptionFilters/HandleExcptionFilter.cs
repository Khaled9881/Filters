using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Filters.ExceptionFilters
{
    public class HandleExcptionFilter(ILogger<HandleExcptionFilter> _logger, IHostEnvironment _hostEnvironment) : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            _logger.LogError("Excption Filter: {filtername}. Method Name: {methodname}.\n {ExceptionType}\n{ExceptionMessage} ⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️", nameof(HandleExcptionFilter), nameof(OnException), context.Exception.GetType().ToString(), context.Exception.Message);

            if (!_hostEnvironment.IsDevelopment())
            {
                context.Result = new ContentResult()
                {
                    Content = context.Exception.Message,
                    ContentType = context.Exception.GetType().ToString(),
                    StatusCode = 500
                };
            }
        }
    }
}
