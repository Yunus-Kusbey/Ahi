using Ahi.UserService.source.Domain.Entities;

namespace Ahi.UserService.source.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<bool> CreateAsync(string phoneNumber);
        Task UpdateRefreshTokenAsync(string refreshToken, User user, DateTime accessTokenDate, int addOnAccessTokenDate);
        int TotalUsersCount();
        Task AssignRoleToUserAsnyc(string userId, string[] roles);
        Task<string[]> GetRolesToUserAsync(string userIdOrName);
        Task<bool> HasRolePermissionToEndpointAsync(string name, string code);
    }
}
