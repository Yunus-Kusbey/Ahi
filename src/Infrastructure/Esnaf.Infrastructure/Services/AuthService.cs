using Esnaf.Application.Abstractions.Services;
using Esnaf.Application.Abstractions.Token;
using Esnaf.Application.Const.Enums;
using Esnaf.Application.DTOs.Auth;
using Esnaf.Application.Exceptions;
using Esnaf.Application.Repositories;
using Esnaf.Application.ViewModels;

namespace Esnaf.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        readonly IRedisCacheService _redisCacheService;
        readonly IUserReadRepository _userRead;
        readonly ITokenHandler _tokenHandler;
        public AuthService(ITokenHandler tokenHandler, IUserReadRepository userRead, IRedisCacheService redisCacheService)
        {
            _tokenHandler = tokenHandler;
            _userRead = userRead;
            _redisCacheService = redisCacheService;
        }

        public Task<Token> GoogleLoginAsynch(string idToken, int accessTokenLifeTime)
        {
            throw new NotImplementedException();
        }

        public async Task<UserAccessedLoginDTO> PhoneLoginAsync(string phoneNumber)
        {
            UserAccessedLoginDTO? a = await _userRead.Control(phoneNumber);
            if (a != null)
            {
                if (a.IsActive)
                {
                    a.Token = _tokenHandler.CreateAccessToken(((int)TokenTime.loginTimeDate), phoneNumber, a.Role.ToString());
                    return a;
                }
                Console.WriteLine("Kullanıcı Aktif Deil");
                return a;
            }
            return null;
        }

        public Task<Token> RefreshTokenLoginAsync(UserLoginDTO userLogin)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SendOTPAsync(string phoneNumber, Int32 code)
        {
            return _redisCacheService.SetCacheValueAsync(phoneNumber, code, 3);
        }

        public async Task<bool> VerifyOTPAsync(UserOTPLoginDTO userLogin)
        {
            if (await _redisCacheService.GetCacheValueAsync(userLogin.Phone.ToString()) == userLogin.OTPCode) return true;
            return false;
        }

        public Task<bool> VerifyResetTokenAsync(string resetToken, Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
