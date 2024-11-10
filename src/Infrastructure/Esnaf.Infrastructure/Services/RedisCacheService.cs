using Esnaf.Application.Abstractions.Services;
using StackExchange.Redis;
using System;
using System.Threading.Tasks;

namespace Esnaf.Infrastructure.Services
{
    public class RedisCacheService : IRedisCacheService
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;
        private readonly IDatabase _db;

        public RedisCacheService(IConnectionMultiplexer redis)
        {
            _connectionMultiplexer = redis;
            _db = _connectionMultiplexer.GetDatabase();
        }

        public async Task<bool> DeleteCacheValueAsync(string key)
        {
            return await _db.KeyDeleteAsync(key);
        }

        public async Task<string?> GetCacheValueAsync(string key)
        {
            if (await _db.KeyExistsAsync(key))
            {
                // Anahtar mevcutsa veriyi al
                var value = await _db.StringGetAsync(key);

                // Veriyi aldıktan sonra anahtarı sil
                await _db.KeyDeleteAsync(key);

                return value;
            }
            return null;
        }

        public async Task<bool> SetCacheValueAsync(string key, Int32 value, short timeInMinutes)
        {
            // Anahtar varsa, değeri güncelle
            return await _db.StringSetAsync(key, value, TimeSpan.FromMinutes(timeInMinutes));
        }
    }
}
