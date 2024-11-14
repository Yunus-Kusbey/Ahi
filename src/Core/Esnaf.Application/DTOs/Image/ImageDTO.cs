using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Image
{
    public class ImageDTO
    {
        public Guid ProductId { get; set; }
        public Guid SellerId { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
