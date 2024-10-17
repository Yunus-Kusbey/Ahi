using Esnaf.Application.DTOs.Address;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Address
{
    public class AddressUpdateCommandRequest:AddressUpdateDTO,IRequest<bool>
    {
    }
}
