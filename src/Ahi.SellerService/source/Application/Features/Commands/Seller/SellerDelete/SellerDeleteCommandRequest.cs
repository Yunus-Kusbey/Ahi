﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.SellerService.source.Application.Features.Commands.Seller
{
    public class SellerDeleteCommandRequest:IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
