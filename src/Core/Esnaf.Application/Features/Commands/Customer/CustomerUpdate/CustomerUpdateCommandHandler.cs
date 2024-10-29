using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Customer
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
            await Task.Delay(500);
            bool a = _repository.Update(request);
            return a;
        }
    }
}
