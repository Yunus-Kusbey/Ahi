using Esnaf.Domain.Entities;
using Esnaf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class CategorySubReadRepository : ICategorySubReadRepository
    {
        public IQueryable<CategorySub> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CategorySub> GetByIdAsync(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<CategorySub> GetWhere()
        {
            throw new NotImplementedException();
        }
    }
}
