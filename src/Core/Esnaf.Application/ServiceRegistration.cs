using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;
namespace Esnaf.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection collection)
        {
            collection.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

            var redisConnection = ConnectionMultiplexer.Connect("localhost:6379"); // Redis server adresi
            collection.AddSingleton<IConnectionMultiplexer>(redisConnection);
            collection.AddStackExchangeRedisCache(option =>
            {
                option.Configuration = "localhost:6379"; //Redis sunucu adresi
                option.InstanceName = "esnaf"; //Örnek bir instance adı
            });
        }
    }
}
