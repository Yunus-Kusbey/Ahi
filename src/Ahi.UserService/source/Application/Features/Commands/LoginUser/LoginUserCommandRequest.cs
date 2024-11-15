using Ahi.UserService.source.Application.DTOs.Auth;
using MediatR;

namespace Ahi.UserService.source.Application.Features.Commands.LoginUser
{
    public class LoginUserCommandRequest : UserOTPLoginDTO, IRequest<LoginUserCommandResponse>
    {
    }
}
