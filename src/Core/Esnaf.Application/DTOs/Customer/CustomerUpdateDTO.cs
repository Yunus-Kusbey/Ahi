using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Customer
{
    public class CustomerUpdateDTO
    {
        public Guid Id;
        public Guid AdressId;
        public string? Name;
        public string? Surname;
        public short Gender;
        public short IsActive;



    }
}
