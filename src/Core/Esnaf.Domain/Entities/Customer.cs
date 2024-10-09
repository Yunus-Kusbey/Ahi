namespace Esnaf.Application.Entities
{
    public class Customer
    {
        public Guid Uid;
        public string? Name;
        public string? Surname;
        public string? Telephone;
        public int AddressId;
        public bool Gender;
        public string? Mail;
        public string? MailId;
        public DateTime BirthDay;
        public DateTime CreatedDate;
        public bool IsActive;
    }
}
