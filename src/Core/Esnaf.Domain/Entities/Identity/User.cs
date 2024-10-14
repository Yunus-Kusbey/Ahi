namespace Esnaf.Domain.Entities.Identity
{
    public class User
    {
        public Guid Id;
        public string? UserName;
        public string? NormalizedUserName;
        public string? Mail;
        public string? MailId;
        public string? NormalizedEmail;
        public bool EmailConfirmed;
        public string? PasswordHash;
        public string? SecurityStamp;
        public string? ConcurrencyStamp;
        public string? PhoneNumber;
        public bool PhoneNumberConfirmed;
        public bool TwoFactorEnabled;
        public DateTime LockoutEnd;
        public bool LockoutEnabled;
        public int AccessFailedCount;
    }
}
