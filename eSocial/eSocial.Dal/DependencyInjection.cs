

using eSocial.Dal.Repository;
using eSocial.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eSocial.Dal
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Contexto>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Conn"),
                b => b.MigrationsAssembly(typeof(Contexto).Assembly.FullName));
            });

            services.AddScoped<IPostRepository, PostRepository>();

            return services;
        }
    }
}