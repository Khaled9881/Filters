using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Filters.ActionFilters
{
    public class WeatherActiinFilter(ILogger<WeatherActiinFilter> logger) : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            string prope = "After Action";
            logger.LogInformation("{prop} ⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️", prope);

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string prope = "Before Action";
            logger.LogInformation("{prop} ⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️", prope);
        }
    }
}
