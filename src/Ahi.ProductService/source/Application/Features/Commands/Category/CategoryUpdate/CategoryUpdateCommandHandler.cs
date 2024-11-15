using Ahi.ProductService.source.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.ProductService.source.Application.Features.Commands.Category
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
            bool a = await _repository.UpdateAsync(request);
            return a;
        }
    }
}
