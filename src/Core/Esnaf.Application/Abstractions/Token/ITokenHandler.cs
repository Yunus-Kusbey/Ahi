using Esnaf.Application.DTOs.Auth;
using Esnaf.Application.ViewModels;
using Esnaf.Domain.Entities.Identity;

namespace Esnaf.Application.Abstractions.Token
{
    public interface ITokenHandler
    {
        ViewModels.Token CreateAccessToken(int second,string id,string role);
        string CreateRefreshToken();
    }
}
