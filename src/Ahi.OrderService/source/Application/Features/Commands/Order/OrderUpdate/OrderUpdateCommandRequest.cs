using Ahi.OrderService.source.Application.DTOs.Order;
using MediatR;

namespace Ahi.OrderService.source.Application.Features.Commands.Order
{
    public class OrderUpdateCommandRequest:OrderUpdateDTO,IRequest<bool>
    {
    }
}
