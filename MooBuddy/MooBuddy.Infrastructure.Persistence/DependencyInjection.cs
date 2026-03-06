using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MooBuddy.Application.Common.Interfaces;
using MooBuddy.Infrastructure.Persistence.Contexts;
using MooBuddy.Infrastructure.Persistence.Repositories;

namespace MooBuddy.Infrastructure.Persistence
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // 1. Đăng ký Entity Framework
            services.AddDbContext<MooBuddyDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
                .UseSnakeCaseNamingConvention());

            // 2. Đăng ký các Repository
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IFamilyRepository, FamilyRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
