using System;

namespace EaseStay.Features.Auth.Data.Models
{
    internal class UserModel
    {
        public Guid UUID { get; private set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }
    }
}
