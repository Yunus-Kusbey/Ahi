using Ahi.UserService.source.Application.ViewModels;

namespace Ahi.UserService.source.Domain.Interfaces.Services
{
    public interface ITokenHandler
    {
        Token CreateAccessToken(int second, string id, string role);
        string CreateRefreshToken();
    }
}
