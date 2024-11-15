using MediatR;

namespace Ahi.OrderService.source.Application.Features.Commands.Cart
{
    public class CartDeleteCommandRequest:IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
