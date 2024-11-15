using Ahi.FileService.source.Domain.Interfaces;
using Ahi.UserService.source.Application.Const.Enums;
using Ahi.UserService.source.Application.DTOs.Auth;
using Ahi.UserService.source.Application.ViewModels;
using Ahi.UserService.source.Domain.Interfaces.Repositories;
using Ahi.UserService.source.Domain.Interfaces.Services;

namespace Ahi.UserService.source.Infrastructure.Infrastructure
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
            if (userLogin != null)
                if (await _redisCacheService.GetCacheValueAsync(userLogin.Phone.ToString()) == userLogin.OTPCode) return true;
            return false;
        }

        public Task<bool> VerifyResetTokenAsync(string resetToken, Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
