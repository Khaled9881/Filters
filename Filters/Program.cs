
using Filters.Filters.ActionFilters;
using Filters.Filters.ExceptionFilters;
using Serilog;

namespace Filters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers(options =>
            {
                //options.Filters.Add<WeatherActiinFilter>();

                var logr = builder.Services.BuildServiceProvider().GetRequiredService<ILogger<WeatherActiinFilter>>();

                //options.Filters.Add(new WeatherActiinFilter(logr, "global_key", "global_vlaue"));

                //options.Filters.Add(new WeatherActiinFilter("global_key", "global_vlaue"));
                options.Filters.Add(new WeatherActiinFilterFactoryAttribute("global_key", "global_vlaue"));

                //options.Filters.Add<HandleExcptionFilter>();
            });
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();


            builder.Host.UseSerilog((context, services, loggerConfig) =>
            {
                loggerConfig.ReadFrom.Configuration(context.Configuration);
                loggerConfig.ReadFrom.Services(services);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();
            app.UseSerilogRequestLogging();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
