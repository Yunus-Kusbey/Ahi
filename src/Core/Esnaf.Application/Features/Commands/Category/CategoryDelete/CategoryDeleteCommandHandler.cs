using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Category
{
    public class CategoryDeleteCommandHandler : IRequestHandler<CategoryDeleteCommandRequest, bool>
    {
        readonly ICategoryWriteRepository _repository;
        public CategoryDeleteCommandHandler(ICategoryWriteRepository writeRepository)
        {
            _repository = writeRepository;
        }

        public async Task<bool> Handle(CategoryDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            return await _repository.DeleteAsync(request.Id);
        }
    }
}
