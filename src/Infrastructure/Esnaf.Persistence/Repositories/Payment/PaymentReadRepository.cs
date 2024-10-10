using Esnaf.Domain.Entities;
using Esnaf.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class PaymentReadRepository : IPaymentReadRepository
    {
        public IQueryable<Payment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Payment> GetByIdAsync(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Payment> GetWhere()
        {
            throw new NotImplementedException();
        }
    }
}
