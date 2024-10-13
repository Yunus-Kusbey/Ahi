using Esnaf.Application.DTOs.Seller;
using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Repositories
{
    public interface ISellerWriteRepository:IWriteRepository<SellerCreate,SellerUpdate>
    {
    }
}
