using Ahi.SellerService.source.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.SellerService.source.Application.Features.Commands.Seller
{
    public class SellerUpdateCommandHandler:IRequestHandler<SellerUpdateCommandRequest,bool>
    {
        readonly ISellerWriteRepository _repository;
        public SellerUpdateCommandHandler(ISellerWriteRepository sellerWrite)
        {
            _repository = sellerWrite;
        }

        public async Task<bool> Handle(SellerUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            bool a = await _repository.UpdateAsync(request);
            return a;
        }
    }
}
