using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Seller
{
    public class SellerCreateCommandHandler : IRequestHandler<SellerCreateCommandRequest, bool>
    {
        readonly ISellerWriteRepository _repository;
        public SellerCreateCommandHandler(ISellerWriteRepository sellerWrite)
        {
            _repository = sellerWrite;
        }
        public async Task<bool> Handle(SellerCreateCommandRequest request, CancellationToken cancellationToken)
        {
            if( await _repository.AddAsync(request)!=Guid.Empty)
                return true;
            return false;
        }
    }
}
