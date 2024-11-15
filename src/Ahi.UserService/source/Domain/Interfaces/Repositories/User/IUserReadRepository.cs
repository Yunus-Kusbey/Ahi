using Ahi.UserService.source.Application.DTOs.Auth;

namespace Ahi.UserService.source.Domain.Interfaces.Repositories
{
    public interface IUserReadRepository : IReadRepository<int>
    {
        public Task<UserAccessedLoginDTO?> Control(string PhoneNumber);
    }
}
