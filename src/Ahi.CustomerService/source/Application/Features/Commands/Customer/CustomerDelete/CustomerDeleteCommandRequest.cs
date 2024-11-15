using MediatR;

namespace Ahi.CustomerService.source.Application.Features.Commands.Customer.CustomerDelete
{
    public class CustomerDeleteCommandRequest : IRequest<bool>
    {
        public Guid Id;
    }
}
