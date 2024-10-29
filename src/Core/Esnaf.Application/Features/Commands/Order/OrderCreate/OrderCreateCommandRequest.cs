using Esnaf.Application.DTOs.Order;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Order
{
    public class OrderCreateCommandRequest:OrderCreateDTO,IRequest<bool>
    {
    }
}
