using Esnaf.Domain.Entities;
using Esnaf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class CategoryReadRepository : ICategoryReadRepository
    {
        public IQueryable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetByIdAsync(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> GetWhere()
        {
            throw new NotImplementedException();
        }
    }
}
