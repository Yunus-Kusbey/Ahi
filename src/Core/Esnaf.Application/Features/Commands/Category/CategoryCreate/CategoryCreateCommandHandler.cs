using Esnaf.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.Category
{
    public class CategoryCreateCommandHandler : IRequestHandler<CategoryCreateCommandRequest, bool>
    {
        readonly ICategoryWriteRepository _repository;
        public CategoryCreateCommandHandler(ICategoryWriteRepository category)
        {
            _repository = category;
        }
        public async Task<bool> Handle(CategoryCreateCommandRequest request, CancellationToken cancellationToken)
        {
            if(await _repository.AddAsync(request)!=-1)
            {
                return true;
            }
            return false;
        }
    }
}
