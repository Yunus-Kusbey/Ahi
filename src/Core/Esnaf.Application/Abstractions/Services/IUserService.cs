using Esnaf.Application.DTOs.User;
using Esnaf.Application.RequestParameters;
using Esnaf.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services
{
    public interface IUserService
    {
        Task<CreateUserResponseDTO> CreateUser(CreateUserDTO userDTO);
        Task UpdateRefreshTokenAsync(string refreshToken, User user, DateTime accessTokenDate, int addOnAccessTokenDate);
        Task<List<ListUserDTO>> GetAllUsersAsync(Pagination pagination);
        int TotalUsersCount();
        Task AssignRoleToUserAsnyc(string userId, string[] roles);
        Task<string[]> GetRolesToUserAsync(string userIdOrName);
        Task<bool> HasRolePermissionToEndpointAsync(string name, string code);
    }
}
