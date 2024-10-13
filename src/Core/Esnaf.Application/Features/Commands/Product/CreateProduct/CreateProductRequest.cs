using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esnaf.Application.DTOs.Product;
using MediatR;
namespace Esnaf.Application.Features.Commands.Product
{
    public class CreateProductRequest : ProductCreate,IRequest<bool>
    {


    }
}
