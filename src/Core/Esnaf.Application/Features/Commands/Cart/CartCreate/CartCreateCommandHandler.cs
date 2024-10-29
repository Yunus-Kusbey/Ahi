using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Cart
{
    public class CartCreateCommandHandler : IRequestHandler<CartCreateCommandRequest, bool>
    {
        readonly ICartWriteRepository _repository;
        public CartCreateCommandHandler(ICartWriteRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> Handle(CartCreateCommandRequest request, CancellationToken cancellationToken)
        {
            if (await _repository.AddAsync(request) != Guid.Empty)
                return true;
            return false;
        }
    }
}
