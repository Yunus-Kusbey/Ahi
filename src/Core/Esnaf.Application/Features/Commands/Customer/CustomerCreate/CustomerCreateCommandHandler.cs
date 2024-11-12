using Esnaf.Application.Repositories;
using MediatR;

namespace Esnaf.Application.Features.Commands.Customer
{
    public class CustomerCreateCommandHandler : IRequestHandler<CustomerCreateCommandRequest, Guid>
    {
        readonly ICustomerWriteRepository _customerWriteRepository;

        public CustomerCreateCommandHandler(ICustomerWriteRepository customerWriteRepository)
        {
            _customerWriteRepository = customerWriteRepository;
        }

        async Task<Guid> IRequestHandler<CustomerCreateCommandRequest, Guid>.Handle(CustomerCreateCommandRequest request, CancellationToken cancellationToken)
        {
            return await _customerWriteRepository.AddAsync(request);               
        }
    }
}
