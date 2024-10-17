using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs
{
    public class UpdateUserDTO
    {
        public Guid Id { get; set; }
        public short IsActive { get; set; }
    }
}
