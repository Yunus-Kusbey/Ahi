﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Category
{
    public class CategoryUpdateDTO
    {
        public Guid Id;
        public string? Name;
        public short IsActived;
    }
}