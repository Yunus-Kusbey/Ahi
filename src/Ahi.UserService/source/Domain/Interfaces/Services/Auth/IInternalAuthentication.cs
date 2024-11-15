using Ahi.UserService.source.Application.DTOs.Auth;
using Ahi.UserService.source.Application.ViewModels;

namespace Ahi.UserService.source.Domain.Interfaces.Services.Auth
{
    public interface IInternalAuthentication
    {
        public Task<UserAccessedLoginDTO> PhoneLoginAsync(string phoneNumber);
        public Task<Token> RefreshTokenLoginAsync(UserLoginDTO userLogin);
    }
}
