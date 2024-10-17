using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Address
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
            return await _addressWriteRepository.DeleteAsync(request.Id);
        }
    }
}
