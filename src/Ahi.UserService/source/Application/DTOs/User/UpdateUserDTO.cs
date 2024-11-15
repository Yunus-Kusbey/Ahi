using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.UserService.source.Application.DTOs
{
    public class UpdateUserDTO
    {
        public Guid Id { get; set; }
        public short IsActive { get; set; }
    }
}
