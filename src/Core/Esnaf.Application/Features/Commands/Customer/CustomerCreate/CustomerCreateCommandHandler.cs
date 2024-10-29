using Esnaf.Application.Repositories;
using MediatR;

namespace Esnaf.Application.Features.Commands.Customer
{
    public class CustomerCreateCommandHandler : IRequestHandler<CustomerCreateCommandRequest, bool>
    {
        readonly ICustomerWriteRepository _customerWriteRepository;

        public CustomerCreateCommandHandler(ICustomerWriteRepository customerWriteRepository)
        {
            _customerWriteRepository = customerWriteRepository;
        }

        async Task<bool> IRequestHandler<CustomerCreateCommandRequest, bool>.Handle(CustomerCreateCommandRequest request, CancellationToken cancellationToken)
        {
            if (await _customerWriteRepository.AddAsync(request) != Guid.Empty)
                return true;
            return false;
        }
    }
}
