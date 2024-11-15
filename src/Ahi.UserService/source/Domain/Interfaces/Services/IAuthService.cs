using Ahi.UserService.source.Application.DTOs.Auth;
using Ahi.UserService.source.Domain.Interfaces.Services.Auth;

namespace Ahi.UserService.source.Domain.Interfaces.Services
{
    public interface IAuthService : IExternalAuthentication, IInternalAuthentication
    {
        public Task<bool> VerifyResetTokenAsync(string resetToken, Guid userId);
        public Task<bool> SendOTPAsync(string phoneNumber, int code);
        public Task<bool> VerifyOTPAsync(UserOTPLoginDTO userLogin);
    }
}
