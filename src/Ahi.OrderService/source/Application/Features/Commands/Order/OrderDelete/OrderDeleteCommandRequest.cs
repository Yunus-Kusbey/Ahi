using MediatR;

namespace Ahi.OrderService.source.Application.Features.Commands.Order
{
    public class OrderDeleteCommandRequest:IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
