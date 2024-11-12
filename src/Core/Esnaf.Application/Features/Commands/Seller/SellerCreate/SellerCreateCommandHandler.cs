using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Seller
{
    public class SellerCreateCommandHandler : IRequestHandler<SellerCreateCommandRequest, Guid>
    {
        readonly ISellerWriteRepository _repository;
        public SellerCreateCommandHandler(ISellerWriteRepository sellerWrite)
        {
            _repository = sellerWrite;
        }
        public async Task<Guid> Handle(SellerCreateCommandRequest request, CancellationToken cancellationToken)
        {
            return await _repository.AddAsync(request);
        }
    }
}
