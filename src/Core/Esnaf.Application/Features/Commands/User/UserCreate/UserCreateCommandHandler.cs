using Esnaf.Application.DTOs.User;
using Esnaf.Application.Repositories;
using MediatR;

namespace Esnaf.Application.Features.Commands.User
{
    public class UserCreateCommandHandler : IRequestHandler<UserCreateCommandRequest, Guid>
    {
        readonly IUserWriteRepository _userWriteRepository;
        public UserCreateCommandHandler(IUserWriteRepository userWrite)
        {
            _userWriteRepository = userWrite;
        }
        public async Task<Guid> Handle(UserCreateCommandRequest request, CancellationToken cancellationToken)
        {
            return await _userWriteRepository.AddAsync(new CreateUserDTO { Phone = request.Phone });
        }
    }
}
