using EaseStay.Core.Database.Builders;
using System;
using System.Data.SqlClient;

namespace EaseStay.Core.Database
{
    internal class Database
    {
        private readonly string _connectionString;

        public Database(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string GetDatabaseName()
        {
            foreach (var part in _connectionString.Split(';'))
            {
                var trimmed = part.Trim();

                if (trimmed.StartsWith("Database=", StringComparison.OrdinalIgnoreCase))
                    return trimmed.Substring("Database=".Length);
            }

            throw new InvalidOperationException("Connection string does not contain a database name.");
        }

        public bool Exists()
        {
            var dbName = GetDatabaseName();

            var masterConnString = _connectionString
                .Replace($"Database={dbName}", "Database=master");

            using (var conn = new SqlConnection(masterConnString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM sys.databases WHERE name = @name", conn))
                {
                    cmd.Parameters.AddWithValue("@name", dbName);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        public void EnsureCreated()
        {
            if (Exists())
                return;

            var dbName = GetDatabaseName();

            var masterConnString = _connectionString
                .Replace($"Database={dbName}", "Database=master");

            using (var conn = new SqlConnection(masterConnString))
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = $"IF DB_ID(N'{dbName}') IS NULL CREATE DATABASE [{dbName}]";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public SqlCreateBuilder Create(string table)
        {
            return new SqlCreateBuilder(table, _connectionString);
        }

        public SqlInsertBuilder Insert(string table)
        {
            return new SqlInsertBuilder(table, _connectionString);
        }

        public SqlUpdateBuilder Update(string table)
        {
            return new SqlUpdateBuilder(table, _connectionString);
        }

        public SqlSelectBuilder Select(string table)
        {
            return new SqlSelectBuilder(table, _connectionString);
        }
    }
}
