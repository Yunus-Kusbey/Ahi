using Esnaf.Application.DTOs.Auth;
using Esnaf.Application.ViewModels;

namespace Esnaf.Application.Abstractions.Token
{
    public interface ITokenHandler
    {
        ViewModels.Token CreateAccessToken(int second,string id,string role);
        string CreateRefreshToken();
    }
}
