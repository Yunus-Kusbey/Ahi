using Esnaf.Application.DTOs.Customer;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Customer
{
    public class CustomerCreateCommandRequest:CustomerCreateDTO,IRequest<bool>
    {
    }
}
