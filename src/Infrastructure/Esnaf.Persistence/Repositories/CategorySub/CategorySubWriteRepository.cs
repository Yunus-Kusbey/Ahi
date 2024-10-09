using Esnaf.Domain.Entities;
using Esnaf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class CategorySubWriteRepository : ICategorySubWriteRepository
    {
        public Task<bool> AddAsync(CategorySub entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(CategorySub id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(CategorySub id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CategorySub entity)
        {
            throw new NotImplementedException();
        }
    }
}
