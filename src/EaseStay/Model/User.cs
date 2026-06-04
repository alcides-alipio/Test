using System;

namespace EaseStay.Model
{
    internal class User
    {
        public Guid UUID { get; private set; }
        public string Email { get; set; }
        public bool EmailVerified { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }

        public User(string email, string firstName, string lastName, string passwordHash)
        {
            UUID = Guid.NewGuid();
            Email = email;
            EmailVerified = false;
            FirstName = firstName;
            LastName = lastName;
            PasswordHash = passwordHash;
        }

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
