using Esnaf.Application.ViewModels;

namespace Esnaf.Application.Features.Commands.AppUser.LoginUser
{
    public class LoginUserCommandResponse
    {
        public Token? Token;
        public bool Register;
        public Guid UserId;
    }
}
