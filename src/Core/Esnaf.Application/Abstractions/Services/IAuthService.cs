using Esnaf.Application.Abstractions.Services.Auth;

namespace Esnaf.Application.Abstractions.Services
{
    public interface IAuthService:IExternalAuthentication,IInternalAuthentication
    {
        public Task<bool> VerifyResetTokenAsync(string resetToken, Guid userId);
    }
}
