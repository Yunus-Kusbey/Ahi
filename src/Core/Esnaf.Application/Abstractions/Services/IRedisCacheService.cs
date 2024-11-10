using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services
{
    public interface IRedisCacheService
    {
        Task<string?> GetCacheValueAsync(string key);
        Task<bool> SetCacheValueAsync(string key, Int32 value,short time);
        Task<bool> DeleteCacheValueAsync(string key);
    }
}
