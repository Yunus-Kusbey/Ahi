using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.ProductService.source.Application.Features.Commands.Product
{
    public class ProductDeleteCommandRequest : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
