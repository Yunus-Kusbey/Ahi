using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Order
{
    public class OrderUpdateCommandHandler : IRequestHandler<OrderUpdateCommandRequest, bool>
    {
        readonly IOrderWriteRepository _repository;
        public OrderUpdateCommandHandler(IOrderWriteRepository orderWrite)
        {
            _repository = orderWrite;
        }
        public async Task<bool> Handle(OrderUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(500);
            bool a =_repository.Update(request);
            return a;
        }
    }
}
