
namespace Ahi.FileService.source.Domain.Interfaces
{
    public interface IRedisCacheService
    {
        Task<bool> GetAsync(string key);
        Task<string?> GetCacheValueAsync(string key);
        Task<bool> SetCacheValueAsync(string key, Int32 value,short timeMinutes);
        Task<bool> DeleteCacheValueAsync(string key);
    }
}
