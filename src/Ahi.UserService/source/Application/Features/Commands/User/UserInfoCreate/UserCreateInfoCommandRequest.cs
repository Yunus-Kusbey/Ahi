using Ahi.UserService.source.Application.DTOs.User;
using MediatR;

namespace Ahi.UserService.source.Application.Features.Commands.User
{
    public class UserInfoCreateCommandRequest : CreateUserInfoDTO, IRequest<bool>
    {
    }
}
