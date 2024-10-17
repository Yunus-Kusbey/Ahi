using Esnaf.Application.Abstractions.Services;
using Esnaf.Application.DTOs;
using Esnaf.Application.DTOs.Auth;

namespace Esnaf.Persistence.Services
{
    public class AuthService : IAuthService
    {
        public Task<TokenDTO> GoogleLoginAsynch(string idToken, int accessTokenLifeTime)
        {
            throw new NotImplementedException();
        }

        public Task<TokenDTO> PhoneLoginAsync(UserLoginDTO userLogin)
        {
            throw new NotImplementedException();
        }

        public Task<TokenDTO> RefreshTokenLoginAsync(UserLoginDTO userLogin)
        {
            throw new NotImplementedException();
        }

        public Task<bool> VerifyResetTokenAsync(string resetToken, Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
