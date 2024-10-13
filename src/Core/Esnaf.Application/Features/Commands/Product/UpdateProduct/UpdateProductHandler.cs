using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Product.UpdateProduct
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductRequest, bool>
    {
        readonly IProductWriteRepository _productWriteRepository;

        public UpdateProductHandler(IProductWriteRepository product)
        {
            _productWriteRepository = product;

        }

        public async Task<bool> Handle(UpdateProductRequest request, CancellationToken cancellationToken)
        {
            return await Task.Run(() => _productWriteRepository.Update(request), cancellationToken);
        }
    }
}
