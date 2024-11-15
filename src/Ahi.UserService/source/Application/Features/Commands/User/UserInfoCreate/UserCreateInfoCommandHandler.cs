using Ahi.UserService.source.Domain.Interfaces.Repositories;
using MediatR;

namespace Ahi.UserService.source.Application.Features.Commands.User
{
    public class UserInfoCreateCommandHandler : IRequestHandler<UserInfoCreateCommandRequest, bool>
    {
        readonly IUserWriteRepository _userWrite;
        public UserInfoCreateCommandHandler(IUserWriteRepository userWrite)
        {
            _userWrite = userWrite;
        }
        public async Task<bool> Handle(UserInfoCreateCommandRequest request, CancellationToken cancellationToken)
        {
            return await _userWrite.UserInfoAddAsync(request);
        }
    }
}
