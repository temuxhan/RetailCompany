using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Store.Management.Service.Infrastructure
{
    public static class InitializeHost
    {
        public static IServiceCollection AddInfrastructure(
           this IServiceCollection services, IConfiguration configuration)
        {
            // Database
            services.AddDbContextFactory<RetailStoreDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("RetailStoreDatabase"));
            });

            return services;
        }
    }
}
