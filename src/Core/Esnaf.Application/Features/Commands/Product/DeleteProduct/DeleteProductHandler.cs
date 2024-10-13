using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esnaf.Application.Repositories;
using MediatR;
namespace Esnaf.Application.Features.Commands.Product
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductRequest, bool>
    {
        readonly IProductWriteRepository _productWriteRepository;
        public DeleteProductHandler(IProductWriteRepository product) {
            _productWriteRepository = product;
        }
        public async Task<bool> Handle(DeleteProductRequest request, CancellationToken cancellationToken)
        {
            return await _productWriteRepository.DeleteAsync(request.Id);
        }
    }
}
