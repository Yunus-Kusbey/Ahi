using Esnaf.Application.DTOs.Order;
using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Repositories
{
    public interface IOrderDetailWriteRepository:IWriteRepository<OrderDetailCreateDTO, OrderDetailUpdateDTO, Guid>
    {
    }
}
