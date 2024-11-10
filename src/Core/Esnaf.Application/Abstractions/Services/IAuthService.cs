using Esnaf.Application.Abstractions.Services.Auth;
using Esnaf.Application.DTOs.Auth;

namespace Esnaf.Application.Abstractions.Services
{
    public interface IAuthService : IExternalAuthentication, IInternalAuthentication
    {
        public Task<bool> VerifyResetTokenAsync(string resetToken, Guid userId);
        public Task<bool> SendOTPAsync(string phoneNumber,Int32 code);
        public Task<bool> VerifyOTPAsync(UserOTPLoginDTO userLogin);
    }
}
