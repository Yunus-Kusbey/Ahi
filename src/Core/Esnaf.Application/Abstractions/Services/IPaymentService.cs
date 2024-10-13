using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services
{
    public interface IPaymentService
    {
        Task OdemeYap();
        Task OdemeSec();
        Task<Address> GetAllPayment();
    }
}
