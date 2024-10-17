using Esnaf.Application.Repositories;
using Esnaf.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class UserReadRepository : IUserReadRepository
    {
        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetWhere()
        {
            throw new NotImplementedException();
        }
    }
}
