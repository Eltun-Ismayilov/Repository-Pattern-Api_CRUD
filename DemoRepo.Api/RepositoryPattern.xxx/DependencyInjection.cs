using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Configuration;


namespace RepositoryPattern.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var conStr = configuration["cString"];

            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(conStr));

            return services;
        }
    }
}

