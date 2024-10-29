using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Cart
{
    public class CartDeleteCommandHandler : IRequestHandler<CartDeleteCommandRequest,bool>
    {
        readonly ICartWriteRepository _repository;
        public CartDeleteCommandHandler(ICartWriteRepository cartWriteRepository)
        {
            _repository = cartWriteRepository;
        }
        public Task<bool> Handle(CartDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            return _repository.DeleteAsync(request.Id);
        }
    }
}
