using MediatR;
using Ahi.ProductService.source.Domain.Interfaces.Repositories;

namespace Ahi.ProductService.source.Application.Features.Commands.Product
{
    public class ProductCreateCommandHandler : IRequestHandler<ProductCreateCommandRequest, string>

    {
        readonly IProductWriteRepository _productWriteRepository;
        public ProductCreateCommandHandler(IProductWriteRepository productWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
        }
        public async Task<string> Handle(ProductCreateCommandRequest request, CancellationToken cancellationToken)
        {
            await _productWriteRepository.AddAsync(request);
            return "Yapım aşamasında";

        }
    }
}
