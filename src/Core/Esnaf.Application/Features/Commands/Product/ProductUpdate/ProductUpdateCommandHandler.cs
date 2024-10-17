using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Product
{
    public class ProductUpdateCommandHandler : IRequestHandler<ProductUpdateCommandRequest, bool>
    {
        readonly IProductWriteRepository _productWriteRepository;

        public ProductUpdateCommandHandler(IProductWriteRepository product)
        {
            _productWriteRepository = product;

        }

        public async Task<bool> Handle(ProductUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            return await Task.Run(() => _productWriteRepository.Update(request), cancellationToken);
        }
    }
}
