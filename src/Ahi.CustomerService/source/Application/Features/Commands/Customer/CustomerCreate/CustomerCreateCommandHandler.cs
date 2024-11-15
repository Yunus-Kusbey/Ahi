using Ahi.CustomerService.source.Domain.Interfaces.Repositories;
using MediatR;

namespace Ahi.CustomerService.source.Application.Features.Commands.Customer.CustomerCreate
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
