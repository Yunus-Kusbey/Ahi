using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services
{
    public interface IService<T> where T : class
    {
        Task Create(T model);
        Task Update(T model);
        Task Delete(Guid id);
        Task<Address> Get(Guid id);
    }
}
