using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Address
{
    public class CreateAddressHandler : IRequestHandler<CreateAddressRequest, bool>
    {
        readonly IAddressWriteRepository _addressRepository;
        public CreateAddressHandler(IAddressWriteRepository addressWrite)
        {
            _addressRepository = addressWrite;
        }

        public async Task<bool> Handle(CreateAddressRequest request, CancellationToken cancellationToken)
        {
           return await _addressRepository.AddAsync(request);
        }
    }
}
