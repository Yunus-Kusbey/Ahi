﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Seller
{
    public class SellerUpdate
    {
        public Guid Id;
        public string? Name;
        public string? VKN;
        public string? Address;
        public short IsActive;
    }
}