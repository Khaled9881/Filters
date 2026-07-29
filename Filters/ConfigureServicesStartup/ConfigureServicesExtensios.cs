using Filters.Filters.ActionFilters;

namespace Filters.ConfigureServicesStartup
{
    public static class ConfigureServicesExtensios
    {


        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddControllers(options =>
             {

                 var logr = services.BuildServiceProvider().GetRequiredService<ILogger<WeatherActiinFilter>>();

                 options.Filters.Add(new WeatherActiinFilterFactoryAttribute("global_key", "global_vlaue"));

             });
            services.AddOpenApi();

            return services;

        }
    }
}
