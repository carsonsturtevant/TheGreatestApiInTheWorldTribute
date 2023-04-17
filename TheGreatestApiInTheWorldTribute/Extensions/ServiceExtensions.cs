using TheGreatestApiInTheWorldTribute.Contracts;
using TheGreatestApiInTheWorldTribute.LoggerService;
using TheGreatestApiInTheWorldTribute.Repository;

namespace TheGreatestApiInTheWorldTribute.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", options =>
                {
                    options.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });
        }

        public static void ConfigureIIS(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options => { });
        }

        public static void ConfigureLogging(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
    }
}
