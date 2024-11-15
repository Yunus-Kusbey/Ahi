using Ahi.UserService.source.Application.ViewModels;

namespace Ahi.UserService.source.Application.Features.Commands.LoginUser
{
    public class LoginUserCommandResponse
    {
        public Token? Token;
        public bool Register;
        public Guid UserId;
    }
}
