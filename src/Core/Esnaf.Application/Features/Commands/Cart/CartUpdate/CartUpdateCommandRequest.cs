using Esnaf.Application.DTOs.Cart;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Cart
{
    public class CartUpdateCommandRequest:CartUpdateDTO,IRequest<bool>
    {

    }
}
