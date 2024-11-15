using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.ProductService.source.Application.Features.Commands.Category
{
    public class CategoryDeleteCommandRequest:IRequest<bool>
    {
        public int Id; 
    }
}
