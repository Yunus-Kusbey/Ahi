using Ahi.UserService.source.Domain.Interfaces.Repositories.Address;
using MediatR;

namespace Ahi.UserService.source.Application.Features.Commands.Address
{
    public class AddressDeleteCommandHandler : IRequestHandler<AddressDeleteCommandRequest, bool>
    {
        readonly IAddressWriteRepository _addressWriteRepository;
        public AddressDeleteCommandHandler(IAddressWriteRepository addressWriteRepository)
        {
            _addressWriteRepository = addressWriteRepository;
        }
        public async Task<bool> Handle(AddressDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            return await _addressWriteRepository.RemoveAsync(request.Id);
        }
    }
}
