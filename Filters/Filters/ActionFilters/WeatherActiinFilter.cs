using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Filters.ActionFilters
{
    public class WeatherActiinFilter(ILogger<WeatherActiinFilter> logger) : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            logger.LogInformation("After Action ⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️");

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            logger.LogInformation("Before Action ⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️");
        }
    }
}
