using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esnaf.Application.Repositories;
using MediatR;
namespace Esnaf.Application.Features.Commands.Product
{
    public class ProductDeleteCommandHandler : IRequestHandler<ProductDeleteCommandRequest, bool>
    {
        readonly IProductWriteRepository _productWriteRepository;
        public ProductDeleteCommandHandler(IProductWriteRepository product) {
            _productWriteRepository = product;
        }
        public async Task<bool> Handle(ProductDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            return await _productWriteRepository.DeleteAsync(request.Id);
        }
    }
}
