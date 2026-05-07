using EaseStay.Core;
using EaseStay.Core.Database;
using EaseStay.Features.Auth.Domain.Entities;
using EaseStay.Features.Auth.Domain.Repositories;
using System;

namespace EaseStay.Features.Auth.Data.Repositories
{
    internal class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository()
        {
            _connectionString = Settings.DB_CONN;
        }

        public User GetByEmail(string email)
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

        public User GetByUUID(Guid uuid)
        {
            Database db = new Database(_connectionString);

            var data = db.Select("Users")
                .Columns("UUID", "Email", "EmailVerified", "FirstName", "LastName", "PasswordHash")
                .Where("UUID", "=", uuid)
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

        public void Add(User user)
        {
            Database db = new Database(_connectionString);

            db.Insert("Users")
                .Columns("Email", "FirstName", "LastName", "PasswordHash")
                .Values(user.Email, user.FirstName, user.LastName, user.PasswordHash)
                .Execute();
        }

        public void Update(User user)
        {
            Database db = new Database(_connectionString);

            db.Update("Users")
                .Set("Email", user.Email)
                .Set("EmailVerified", user.EmailVerified)
                .Set("FirstName", user.FirstName)
                .Set("LastName", user.LastName)
                .Set("PasswordHash", user.PasswordHash)
                .Where("UUID", "=", user.UUID)
                .Execute();
        }

    }
}
