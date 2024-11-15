using Ahi.UserService.source.Domain.Interfaces.Repositories.Address;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.UserService.source.Application.Features.Commands.Address
{
    public class AddressUpdateCommandHandler : IRequestHandler<AddressUpdateCommandRequest, bool>
    {
        readonly IAddressWriteRepository _addressWriteRepository;
        public AddressUpdateCommandHandler(IAddressWriteRepository addressWriteRepository)
        {
            _addressWriteRepository = addressWriteRepository;
        }
        public async Task<bool> Handle(AddressUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            bool a = await _addressWriteRepository.UpdateAsync(request);
            return a;
        }
    }
}
