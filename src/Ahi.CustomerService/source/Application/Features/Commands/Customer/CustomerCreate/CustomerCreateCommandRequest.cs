using Ahi.CustomerService.source.Application.DTOs.Customer;
using MediatR;

namespace Ahi.CustomerService.source.Application.Features.Commands.Customer.CustomerCreate
{
    public class CustomerCreateCommandRequest : CustomerCreateDTO, IRequest<Guid>
    {
    }
}
