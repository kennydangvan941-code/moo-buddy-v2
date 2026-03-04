using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MooBuddy.Infrastructure.Persistence.Contexts;

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

            // 2. Đăng ký các Repository hoặc Service hạ tầng khác
            // services.AddScoped<IEmailService, EmailService>();

            return services;
        }
    }
}
