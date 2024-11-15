using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.UserService.source.Application.Features.Commands.Address
{
    public class AddressDeleteCommandRequest:IRequest<bool>
    {
        public Guid Id;
    }
}
