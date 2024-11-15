using Ahi.CustomerService.source.Domain.Interfaces.Repositories;
using MediatR;

namespace Ahi.CustomerService.source.Application.Features.Commands.Customer.CustomerDelete
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
            return await _customerWriteRepository.RemoveAsync(request.Id);
        }
    }
}
