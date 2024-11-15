using Ahi.ProductService.source.Domain.Interfaces.Repositories;
using MediatR;

namespace Ahi.ProductService.source.Application.Features.Commands.Product
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
            return await _productWriteRepository.UpdateAsync(request);
        }
    }
}
