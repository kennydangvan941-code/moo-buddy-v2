using Microsoft.Extensions.DependencyInjection;
using MooBuddy.Application.Features.Auth.RegisterWithEmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MooBuddy.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<RegisterWithEmailExecution>();

            return services;
        }
    }
}
