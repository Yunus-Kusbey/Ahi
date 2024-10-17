using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Cart
{
    public class CartUpdateDTO
    {
        public Guid Id;
        public int Total;
        public short IsActive;
    }
}
