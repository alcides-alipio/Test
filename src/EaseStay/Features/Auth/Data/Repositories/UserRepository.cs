using EaseStay.Core.Database;
using EaseStay.Features.Auth.Domain.Entities;
using EaseStay.Features.Auth.Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace EaseStay.Features.Auth.Data.Repositories
{
    internal class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository()
        {
            _connectionString =
                "Server=(LocalDB)\\MSSQLLocalDB;Database=PSI1624U_AlcidesAlipio_2224107;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        public User GetByEmailAsync(string email)
        {
            Database db = new Database(_connectionString);

            var data = db.Select("Users")
                .Columns("UUID", "Email", "EmailVerified", "FirstName", "LastName", "PasswordHash")
                .Where("Email", "=", email)
                .Execute();

            if (data.Count <= 0)
                return null;

            return new User
            (
                Guid.Parse(data[0]["UUID"].ToString()),
                data[0]["Email"].ToString(),
                Convert.ToBoolean(data[0]["EmailVerified"]),
                data[0]["FirstName"].ToString(),
                data[0]["LastName"].ToString(),
                data[0]["PasswordHash"].ToString()
            );
        }

        public void AddAsync(User user)
        {
            Database db = new Database(_connectionString);

            db.Insert("Users")
                .Columns("Email", "FirstName", "LastName", "PasswordHash")
                .Values(user.Email, user.FirstName, user.LastName, user.PasswordHash)
                .Execute();
        }
    }
}
