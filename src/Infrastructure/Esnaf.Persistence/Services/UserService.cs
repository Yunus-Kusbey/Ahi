using Esnaf.Application.Abstractions.Services;
using Esnaf.Application.DTOs.Auth;
using Esnaf.Application.DTOs.User;
using Esnaf.Application.Repositories;
using Esnaf.Application.RequestParameters;
using Esnaf.Domain.Entities.Identity;

namespace Esnaf.Persistence.Services
{
    public class UserService : IUserService
    {
        readonly IAuthService _authService;
        readonly IUserWriteRepository _writeRepository;
        public UserService(IUserWriteRepository writeRepository, IAuthService authService)
        {
            _authService = authService;
            _writeRepository = writeRepository;
        }
        public Task AssignRoleToUserAsnyc(string userId, string[] roles)
        {
            throw new NotImplementedException();
        }

        public async Task<CreateUserResponseDTO> CreateUser(CreateUserDTO userDTO)
        {
            return new CreateUserResponseDTO()
            {
                Succeeded = true,
                Message = await _writeRepository.AddAsync(userDTO)
            };
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
