using Ahi.ProductService.source.Domain.Interfaces.Repositories;
using MediatR;
namespace Ahi.ProductService.source.Application.Features.Commands.Product
{
    public class ProductDeleteCommandHandler : IRequestHandler<ProductDeleteCommandRequest, bool>
    {
        readonly IProductWriteRepository _productWriteRepository;
        public ProductDeleteCommandHandler(IProductWriteRepository product) {
            _productWriteRepository = product;
        }
        public async Task<bool> Handle(ProductDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            return await _productWriteRepository.RemoveAsync(request.Id);
        }
    }
}
