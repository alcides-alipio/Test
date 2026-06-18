using EaseStay.Core.Database.Models;
using System;

namespace EaseStay.Core.Database.Repositories
{
    internal class UserRepository
    {
        public UserModel GetByEmail(string email)
        {
            Database db = new Database(Settings.DB_CONN);

            var data = db.Select("Users")
                .Columns("UUID", "Email", "EmailVerified", "FirstName", "LastName", "PasswordHash")
                .Where("Email", "=", email)
                .Execute();

            if (data.Count <= 0)
                return null;

            return new UserModel
            (
                Guid.Parse(data[0]["UUID"].ToString()),
                data[0]["Email"].ToString(),
                Convert.ToBoolean(data[0]["EmailVerified"]),
                data[0]["FirstName"].ToString(),
                data[0]["LastName"].ToString(),
                data[0]["PasswordHash"].ToString()
            );
        }

        public UserModel GetByUUID(Guid userUUID)
        {
            Database db = new Database(Settings.DB_CONN);

            var data = db.Select("Users")
                .Columns("UUID", "Email", "EmailVerified", "FirstName", "LastName", "PasswordHash")
                .Where("UUID", "=", userUUID)
                .Execute();

            if (data.Count <= 0)
                return null;

            return new UserModel
            (
                Guid.Parse(data[0]["UUID"].ToString()),
                data[0]["Email"].ToString(),
                Convert.ToBoolean(data[0]["EmailVerified"]),
                data[0]["FirstName"].ToString(),
                data[0]["LastName"].ToString(),
                data[0]["PasswordHash"].ToString()
            );
        }

        public void Add(UserModel user)
        {
            Database db = new Database(Settings.DB_CONN);

            db.Insert("Users")
                .Columns("Email", "FirstName", "LastName", "PasswordHash")
                .Values(user.Email, user.FirstName, user.LastName, user.PasswordHash)
                .Execute();
        }

        public void Update(UserModel user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            Database db = new Database(Settings.DB_CONN);

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
