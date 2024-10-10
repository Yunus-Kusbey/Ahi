using Esnaf.Domain.Entities;
using Esnaf.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class PaymentWriteRepository : IPaymentWriteRepository
    {
        public Task<bool> AddAsync(Payment entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Payment id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Payment id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Payment entity)
        {
            throw new NotImplementedException();
        }
    }
}
