using Ahi.SellerService.source.Application.DTOs.Seller;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.SellerService.source.Application.Features.Commands.Seller
{
    public class SellerUpdateCommandRequest:SellerUpdateDTO,IRequest<bool>
    {
    }
}
