using Ahi.OrderService.source.Domain.Interfaces.Repositories;
using MediatR;

namespace Ahi.OrderService.source.Application.Features.Commands.Cart
{
    public class CartUpdateCommandHandler:IRequestHandler<CartUpdateCommandRequest,bool>
    {
        readonly ICartWriteRepository _repository;
        public CartUpdateCommandHandler(ICartWriteRepository cartWrite)
        {
            _repository = cartWrite;
        }

        public async Task<bool> Handle(CartUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            bool a = await _repository.UpdateAsync(request);
            return a;
        }
    }
}
