using Esnaf.Application.Abstractions.Token;
using Esnaf.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Esnaf.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
        }
    }
}
