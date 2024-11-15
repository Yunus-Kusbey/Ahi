using Ahi.OrderService.source.Domain.Interfaces.Repositories;
using MediatR;

namespace Ahi.OrderService.source.Application.Features.Commands.Order.OrderCreate
{
    public class OrderCreateCommandHandler : IRequestHandler<OrderCreateCommandRequest, bool>
    {
        readonly IOrderWriteRepository _repository;
        public OrderCreateCommandHandler(IOrderWriteRepository orderWrite)
        {
            _repository = orderWrite;
        }

        public async Task<bool> Handle(OrderCreateCommandRequest request, CancellationToken cancellationToken)
        {
            if (await _repository.AddAsync(request) != Guid.Empty)
                return true;
            return false;
        }
    }
}
