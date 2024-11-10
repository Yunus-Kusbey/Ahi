using Esnaf.Application.Abstractions.Services;
using Esnaf.Application.Abstractions.Token;
using Esnaf.Application.Const;
using Esnaf.Application.DTOs.Auth;
using Esnaf.Application.Exceptions;
using Esnaf.Application.Repositories;
using Esnaf.Application.ViewModels;

namespace Esnaf.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        readonly IUserReadRepository _userRead;
        readonly ITokenHandler _tokenHandler;
        public AuthService(ITokenHandler tokenHandler, IUserReadRepository userRead)
        {
            _tokenHandler = tokenHandler;
            _userRead = userRead;
        }

        public Task<Token> GoogleLoginAsynch(string idToken, int accessTokenLifeTime)
        {
            throw new NotImplementedException();
        }

        public async Task<Token?> PhoneLoginAsync(string phoneNumber)
        {
            UserAccessedLoginDTO a = await _userRead.Control(phoneNumber);
            if (a.IsActive)
                return _tokenHandler.CreateAccessToken(((int)TokenTime.loginTimeDate), phoneNumber, a.Role);
            else if (a.Equals(null))
            {
                return null;
                throw new NotFoundUserException();
            }
            else throw new NotFoundUserException();
        }

        public Task<Token> RefreshTokenLoginAsync(UserLoginDTO userLogin)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SendOTPAsync(string phoneNumber, Int32 code)
        {
            return Task.FromResult(true);
        }

        public Task<bool> VerifyOTPAsync(UserOTPLoginDTO userLogin)
        {
            throw new NotImplementedException();
        }

        public Task<bool> VerifyResetTokenAsync(string resetToken, Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
