using Esnaf.Application.DTOs.Auth;
using Esnaf.Application.ViewModels;
namespace Esnaf.Application.Abstractions.Services.Auth
{
    public interface IInternalAuthentication
    {
        public Task<UserAccessedLoginDTO> PhoneLoginAsync(string phoneNumber);
        public Task<ViewModels.Token> RefreshTokenLoginAsync(UserLoginDTO userLogin);
    }
}
