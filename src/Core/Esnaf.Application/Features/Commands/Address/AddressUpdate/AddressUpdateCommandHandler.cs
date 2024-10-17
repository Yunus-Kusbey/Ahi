using Esnaf.Application.DTOs.Address;
using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Address
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
            return  _addressWriteRepository.Update(request);
        }
    }
}
