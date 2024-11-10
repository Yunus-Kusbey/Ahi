using Esnaf.Application.Abstractions.Services;
using Esnaf.Application.Abstractions.Token;
using Esnaf.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace Esnaf.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITokenHandler, TokenHandler>();
            services.AddScoped<IRedisCacheService, RedisCacheService>();
        }
    }
}
