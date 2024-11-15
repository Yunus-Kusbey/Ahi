using Ahi.UserService.source.Domain.Entities;
using Ahi.UserService.source.Domain.Interfaces.Services;

namespace Ahi.UserService.source.Infrastructure.Infrastructure
{
    public class UserService : IUserService
    {
        public Task AssignRoleToUserAsnyc(string userId, string[] roles)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<string[]> GetRolesToUserAsync(string userIdOrName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasRolePermissionToEndpointAsync(string name, string code)
        {
            throw new NotImplementedException();
        }

        public int TotalUsersCount()
        {
            throw new NotImplementedException();
        }

        public Task UpdateRefreshTokenAsync(string refreshToken, User user, DateTime accessTokenDate, int addOnAccessTokenDate)
        {
            throw new NotImplementedException();
        }
    }
}
