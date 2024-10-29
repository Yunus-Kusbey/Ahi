using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Seller
{
    public class SellerDeleteCommandHandler:IRequestHandler<SellerDeleteCommandRequest,bool>
    {
        readonly ISellerWriteRepository _repository;
        public SellerDeleteCommandHandler(ISellerWriteRepository sellerWrite)
        {
            _repository = sellerWrite;
        }

        public async Task<bool> Handle(SellerDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            return await _repository.DeleteAsync(request.Id);
        }
    }
}
