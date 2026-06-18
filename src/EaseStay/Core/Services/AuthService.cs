using EaseStay.Core.Database.Repositories;
using EaseStay.Core.Database.Models;
using System;

namespace EaseStay.Core.Services
{
    internal static class AuthService
    {
        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
                return false;

            bool hasLetter = false, hasDigit = false, hasSpecial = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c)) hasLetter = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else hasSpecial = true;

                if (hasLetter && hasDigit && hasSpecial)
                    return true;
            }
            return false;
        }

        public static bool VerifyPassword(string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }

        public static void ChangePassword(UserModel user, string newPassword)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            if (!IsValidPassword(newPassword))
                throw new ArgumentException("Password does not meet security requirements.", nameof(newPassword));

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);

            UserRepository repo = new UserRepository();
            repo.Update(user);
        }

        public static UserModel GetUserByEmail(string email)
        {
            UserRepository repo = new UserRepository();
            return repo.GetByEmail(email);
        }

        public static UserModel GetUserByUUID(Guid userUUID)
        {
            UserRepository repo = new UserRepository();
            return repo.GetByUUID(userUUID);
        }

        public static void RegisterUser(UserModel user)
        {
            UserRepository repo = new UserRepository();
            repo.Add(user);
        }
    }
}
