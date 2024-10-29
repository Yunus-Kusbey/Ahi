using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Category
{
    public class CategoryUpdateCommandHandler : IRequestHandler<CategoryUpdateCommandRequest, bool>
    {
        readonly ICategoryWriteRepository _repository;
        public CategoryUpdateCommandHandler(ICategoryWriteRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> Handle(CategoryUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(500);
            bool a = _repository.Update(request);
            return a;
        }
    }
}
