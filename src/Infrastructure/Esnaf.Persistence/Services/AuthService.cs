using Esnaf.Application.Abstractions.Services;
using Esnaf.Application.Abstractions.Token;
using Esnaf.Application.DTOs.Auth;
using Esnaf.Application.Exceptions;
using Esnaf.Application.Repositories;
using Esnaf.Application.ViewModels;

namespace Esnaf.Persistence.Services
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

        public async Task<Token> PhoneLoginAsync(UserLoginDTO userLogin, int minute)
        {
            UserAccessedLoginDTO a = await _userRead.Control(userLogin.Phone.ToString());
            if (a.IsActive)
                return _tokenHandler.CreateAccessToken(minute, userLogin.Phone.ToString(),a.Role);
            else throw new NotFoundUserException();
        }

        public Task<Token> RefreshTokenLoginAsync(UserLoginDTO userLogin)
        {
            throw new NotImplementedException();
        }

        public Task<bool> VerifyResetTokenAsync(string resetToken, Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
