namespace Esnaf.Domain.Entities
{
    public class Customer
    {
        public Guid Id;
        public string? Name;
        public string? Surname;
        public string? Telephone;
        public Guid AddressId;
        public bool Gender;
        public string? Mail;
        public int MailId;
        public DateTime BirthDay;
        public DateTime CreatedDate;
        public bool IsActive;
    }
}
