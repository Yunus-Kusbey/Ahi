using Ahi.UserService.source.Application.ViewModels;

namespace Ahi.UserService.source.Domain.Interfaces.Services.Auth
{
    public interface IExternalAuthentication
    {
        public Task<Token> GoogleLoginAsynch(string idToken, int accessTokenLifeTime);
    }
}
