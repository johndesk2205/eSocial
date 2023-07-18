

using eSocial.Application.Posts.Commands;
using eSocial.Dal;
using eSocial.Dal.Repository;
using eSocial.Domain.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eSocial.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Contexto>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Conn"),
                c => c.MigrationsAssembly(typeof(Contexto).Assembly.FullName));
            });

            services.AddScoped<IPostRepository, PostRepository>();
            services.AddMediatR(typeof(CreatePostCommand));

            return services;
        }
    }
}