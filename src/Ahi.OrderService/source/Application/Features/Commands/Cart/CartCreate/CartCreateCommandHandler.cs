using Ahi.OrderService.source.Domain.Interfaces.Repositories;
using MediatR;

namespace Ahi.OrderService.source.Application.Features.Commands.Cart
{
    public class CartCreateCommandHandler : IRequestHandler<CartCreateCommandRequest, bool>
    {
        readonly ICartWriteRepository _repository;
        public CartCreateCommandHandler(ICartWriteRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> Handle(CartCreateCommandRequest request, CancellationToken cancellationToken)
        {
            if (await _repository.AddAsync(request) != Guid.Empty)
                return true;
            return false;
        }
    }
}
