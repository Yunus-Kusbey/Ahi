using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Order
{
    public class OrderDeleteCommandHandler:IRequestHandler<OrderDeleteCommandRequest,bool>
    {
        readonly IOrderWriteRepository _repository;
        public OrderDeleteCommandHandler(IOrderWriteRepository repository)
        {
            _repository = repository;
        }

        public Task<bool> Handle(OrderDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            return _repository.DeleteAsync(request.Id);
        }
    }
}
