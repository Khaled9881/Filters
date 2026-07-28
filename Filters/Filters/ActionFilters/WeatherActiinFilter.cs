using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Filters.ActionFilters
{

    public class WeatherActiinFilterFactoryAttribute : Attribute, IFilterFactory
    {
        private readonly string key;
        private readonly string value;

        public bool IsReusable => false;


        public WeatherActiinFilterFactoryAttribute(string key, string value)
        {
            this.key = key;
            this.value = value;
        }

        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
        {
            var logger = serviceProvider.GetRequiredService<ILogger<WeatherActiinFilter>>();
            return new WeatherActiinFilter(logger, key, value);
        }
    }

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


        //public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        //{
        //    string prope = "After Action";
        //    Console.WriteLine("{0} ⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️", prope);

        //    await next();

        //    prope = "Before Action";
        //    Console.WriteLine("{0} ⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️⚠️", prope);
        //    context.HttpContext.Response.Headers[key] = value;
        //}

    }
}
