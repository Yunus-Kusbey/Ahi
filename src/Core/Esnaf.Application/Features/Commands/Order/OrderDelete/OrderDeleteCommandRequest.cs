using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Order
{
    public class OrderDeleteCommandRequest:IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
