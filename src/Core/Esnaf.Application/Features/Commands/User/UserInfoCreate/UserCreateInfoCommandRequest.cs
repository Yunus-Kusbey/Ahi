using Esnaf.Application.DTOs.User;
using MediatR;

namespace Esnaf.Application.Features.Commands.User
{
    public class UserInfoCreateCommandRequest : CreateUserInfoDTO, IRequest<bool>
    {
    }
}
