using Ahi.UserService.source.Application.DTOs;
using Ahi.UserService.source.Application.DTOs.User;

namespace Ahi.UserService.source.Domain.Interfaces.Repositories
{
    public interface IUserWriteRepository : IWriteRepository<CreateUserDTO, UpdateUserDTO, Guid>
    {
        Task<bool> UserInfoAddAsync(CreateUserInfoDTO create);
    }
}
