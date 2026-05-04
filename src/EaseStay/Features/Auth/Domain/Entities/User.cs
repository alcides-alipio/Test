using System;

namespace EaseStay.Features.Auth.Domain.Entities
{
    public class User
    {
        public Guid UUID { get; private set; }
        public string Email { get; set; }
        public bool EmailVerified { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }

        public User()
            : this(Guid.NewGuid(), string.Empty, false, string.Empty, string.Empty, string.Empty) { }

        public User(string email, bool emailVerified, string firstName, string lastName, string passwordHash)
            : this(Guid.NewGuid(), email, emailVerified, firstName, lastName, passwordHash) { }

        public User(Guid uuid, string email, bool emailVerified, string firstName, string lastName, string passwordHash)
        {
            UUID = uuid;
            Email = email;
            EmailVerified = emailVerified;
            FirstName = firstName;
            LastName = lastName;
            PasswordHash = passwordHash;
        }
    }
}
