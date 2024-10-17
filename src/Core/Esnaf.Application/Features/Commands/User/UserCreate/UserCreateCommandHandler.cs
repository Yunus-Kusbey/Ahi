using Esnaf.Application.Abstractions.Services;
using Esnaf.Application.DTOs.User;
using MediatR;

namespace Esnaf.Application.Features.Commands.User
{
    public class UserCreateCommandHandler : IRequestHandler<UserCreateCommandRequest, CreateUserResponseDTO>
    {
        readonly IUserService _userService;
        IAuthService _authService;
        public UserCreateCommandHandler(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }
        public async Task<CreateUserResponseDTO> Handle(UserCreateCommandRequest request, CancellationToken cancellationToken)
        {
            return await _userService.CreateUser(request);
        }
    }
}
