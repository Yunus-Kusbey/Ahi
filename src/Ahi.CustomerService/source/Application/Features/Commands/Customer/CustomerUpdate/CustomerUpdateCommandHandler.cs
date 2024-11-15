using Ahi.CustomerService.source.Domain.Interfaces.Repositories;
using MediatR;

namespace Ahi.CustomerService.source.Application.Features.Commands.Customer.CustomerUpdate
{
    public class CustomerUpdateCommandHandler : IRequestHandler<CustomerUpdateCommandRequest, bool>
    {
        readonly ICustomerWriteRepository _repository;
        public CustomerUpdateCommandHandler(ICustomerWriteRepository customerWrite)
        {
            _repository = customerWrite;
        }

        public async Task<bool> Handle(CustomerUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            bool a = await _repository.UpdateAsync(request);
            return a;
        }
    }
}
