using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Customer
{
    public class CustomerDeleteCommandHandler : IRequestHandler<CustomerDeleteCommandRequest, bool>
    {
        readonly ICustomerWriteRepository _customerWriteRepository;
        public CustomerDeleteCommandHandler(ICustomerWriteRepository customerWriteRepository)
        {
            _customerWriteRepository = customerWriteRepository;
        }
        public async Task<bool> Handle(CustomerDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            return await _customerWriteRepository.DeleteAsync(request.Id);
        }
    }
}
