using Esnaf.Application.Abstractions.Services;
using Esnaf.Application.Repositories;
using MediatR;

namespace Esnaf.Application.Features.Commands.User
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
