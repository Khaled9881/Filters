using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Filters.ActionFilters
{
    public class WeatherActiinFilter(ILogger<WeatherActiinFilter> logger, string key, string value) : IAsyncActionFilter
    {
        //public void OnActionExecuted(ActionExecutedContext context)
        //{
        //    string prope = "After Action";
        //    logger.LogInformation("{prop} ⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️", prope);

        //}

        //public void OnActionExecuting(ActionExecutingContext context)
        //{
        //    string prope = "Before Action";
        //    logger.LogInformation("{prop} ⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️", prope);

        //    context.HttpContext.Response.Headers[key] = value;
        //}

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            string prope = "After Action";
            logger.LogInformation("{prop} ⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️", prope);

            await next();

            prope = "Before Action";
            logger.LogInformation("{prop} ⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️", prope);
            context.HttpContext.Response.Headers[key] = value;
        }
    }
}
