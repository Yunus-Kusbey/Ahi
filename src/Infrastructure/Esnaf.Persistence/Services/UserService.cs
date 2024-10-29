using Esnaf.Application.Abstractions.Services;
using Esnaf.Application.DTOs.Auth;
using Esnaf.Application.DTOs.User;
using Esnaf.Application.Repositories;
using Esnaf.Application.RequestParameters;
using Esnaf.Domain.Entities;

namespace Esnaf.Persistence.Services
{
    public class UserService : IUserService
    {
        public Task AssignRoleToUserAsnyc(string userId, string[] roles)
        {
            throw new NotImplementedException();
        }
        public Task<List<ListUserDTO>> GetAllUsersAsync(Pagination pagination)
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
