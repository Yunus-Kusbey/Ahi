using Ahi.OrderService.source.Application.DTOs.Cart;
using MediatR;

namespace Ahi.OrderService.source.Application.Features.Commands.Cart
{
    public class CartUpdateCommandRequest:CartUpdateDTO,IRequest<bool>
    {

    }
}
