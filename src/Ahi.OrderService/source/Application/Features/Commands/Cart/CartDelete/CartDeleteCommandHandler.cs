using Ahi.OrderService.source.Domain.Interfaces.Repositories;
using MediatR;

namespace Ahi.OrderService.source.Application.Features.Commands.Cart
{
    public class CartDeleteCommandHandler : IRequestHandler<CartDeleteCommandRequest,bool>
    {
        readonly ICartWriteRepository _repository;
        public CartDeleteCommandHandler(ICartWriteRepository cartWriteRepository)
        {
            _repository = cartWriteRepository;
        }
        public Task<bool> Handle(CartDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            return _repository.RemoveAsync(request.Id);
        }
    }
}
