using Esnaf.Domain.Entities;
using Esnaf.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esnaf.Application.DTOs.Category;

namespace Esnaf.Persistence.Repositories
{
    public class CategoryWriteRepository : ICategoryWriteRepository
    {
        public Task<bool> AddAsync(CategoryCreate entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CategoryUpdate entity)
        {
            throw new NotImplementedException();
        }
    }
}
