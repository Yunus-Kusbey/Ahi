using Ahi.CustomerService.source.Application.DTOs.Customer;
using MediatR;

namespace Ahi.CustomerService.source.Application.Features.Commands.Customer.CustomerUpdate
{
    public class CustomerUpdateCommandRequest : CustomerUpdateDTO, IRequest<bool>
    {
    }
}
