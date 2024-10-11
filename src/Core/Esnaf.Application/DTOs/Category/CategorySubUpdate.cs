using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Category
{
    public class CategorySubUpdate
    {
        public Guid Id;
        public Guid CategoryId;
        public string? Name;
        public short IsActive;

    }
}
