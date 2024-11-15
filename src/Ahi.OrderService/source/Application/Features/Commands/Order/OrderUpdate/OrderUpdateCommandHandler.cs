using Ahi.OrderService.source.Domain.Interfaces.Repositories;
using MediatR;

namespace Ahi.OrderService.source.Application.Features.Commands.Order
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
            bool a =await _repository.UpdateAsync(request);
            return a;
        }
    }
}
