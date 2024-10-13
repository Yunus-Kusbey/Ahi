using MediatR;
using Esnaf.Application.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Product.CreateProduct
{
    public class CreateProductHandler : IRequestHandler<CreateProductRequest,CreateProductResponse>

    {
        readonly IProductWriteRepository _productRepository;
        public CreateProductHandler(IProductWriteRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<CreateProductResponse> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {
            CreateProductResponse response = await _productRepository.AddAsync(new ()
            {

            }
                );
           {

            }
        }
    }
}
