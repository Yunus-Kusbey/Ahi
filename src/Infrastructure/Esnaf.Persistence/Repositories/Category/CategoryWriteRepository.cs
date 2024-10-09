using Esnaf.Domain.Entities;
using Esnaf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class CategoryWriteRepository : ICategoryWriteRepository
    {
        public Task<bool> AddAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Category id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Category id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
