using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Cart
{
    public class CartUpdateCommandHandler:IRequestHandler<CartUpdateCommandRequest,bool>
    {
        readonly ICartWriteRepository _repository;
        public CartUpdateCommandHandler(ICartWriteRepository cartWrite)
        {
            _repository = cartWrite;
        }

        public async Task<bool> Handle(CartUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(500);
            bool a = _repository.Update(request);
            return a;
        }
    }
}
