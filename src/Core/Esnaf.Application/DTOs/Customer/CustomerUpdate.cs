using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Customer
{
    public class CustomerUpdate
    {
        public Guid Id;
        public Guid AdressId;
        public string? Name;
        public string? Surname;
        public string? Email;
        public short MailId;
        public string? Phone;
        public short Gender;
        public DateTime BirthDate;
        public short IsActive;



    }
}
