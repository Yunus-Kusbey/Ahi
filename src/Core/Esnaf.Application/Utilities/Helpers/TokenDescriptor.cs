using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Utilities.Helpers
{
    public class TokenDescriptor
    {
        public ClaimsIdentity Claims { get; set; }
        public string Secret { get; set; }
        public DateTime ExpiresValue { get; set; }

    }
}
