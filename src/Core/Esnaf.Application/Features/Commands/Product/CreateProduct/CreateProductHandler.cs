using MediatR;
using Esnaf.Application.Repositories;

namespace Esnaf.Application.Features.Commands.Product
{
    public class CreateProductHandler : IRequestHandler<CreateProductRequest,bool>

    {
        readonly IProductWriteRepository _productWriteRepository;
        public CreateProductHandler(IProductWriteRepository productWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
        }
        public async Task<bool> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {
            return await _productWriteRepository.AddAsync(request);

            
        }
    }
}
