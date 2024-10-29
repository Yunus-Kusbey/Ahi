using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Seller
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
            await Task.Delay(500);
            bool a = _repository.Update(request);
            return a;
        }
    }
}
