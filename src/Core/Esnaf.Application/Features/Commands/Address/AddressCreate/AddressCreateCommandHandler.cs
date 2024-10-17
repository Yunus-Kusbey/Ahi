using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Address
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
