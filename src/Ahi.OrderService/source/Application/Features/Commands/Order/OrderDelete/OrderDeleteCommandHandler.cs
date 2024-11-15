using Ahi.OrderService.source.Domain.Interfaces.Repositories;
using MediatR;

namespace Ahi.OrderService.source.Application.Features.Commands.Order
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
            return _repository.RemoveAsync(request.Id);
        }
    }
}
