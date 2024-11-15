using Ahi.UserService.source.Domain.Interfaces.Repositories.Address;
using MediatR;

namespace Ahi.UserService.source.Application.Features.Commands.Address
{
    public class AddressCreateCommandHandler : IRequestHandler<AddressCreateCommandRequest, Guid>
    {
        readonly IAddressWriteRepository _addressRepository;
        public AddressCreateCommandHandler(IAddressWriteRepository addressWrite)
        {
            _addressRepository = addressWrite;
        }

        public async Task<Guid> Handle(AddressCreateCommandRequest request, CancellationToken cancellationToken)
        {
           return await _addressRepository.AddAsync(request);
        }
    }
}
