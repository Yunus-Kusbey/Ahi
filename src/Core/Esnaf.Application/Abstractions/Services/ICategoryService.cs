using Esnaf.Application.DTOs.Category;
using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services
{
    public interface ICategoryService
    {
        Task CreateCategory(CategoryCreate model);
        Task CreateSubCategory(CategorySubCreate model);
        Task UpdateCategory(CategoryUpdate model);
        Task UpdateSubCategory(CategorySubUpdate model);
        Task DeleteCategory(Guid uid);
        Task DeleteSubCategory(Guid uid);
        Task<Address> GetAllCart(Guid uid);
    }
}
