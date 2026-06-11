using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EaseStay.Core.Database.Builders
{
    internal class SqlCreateBuilder
    {
        private readonly string _connectionString;
        private readonly string _table;

        private readonly List<string> _columns = new List<string>();

        public SqlCreateBuilder(string table, string connectionString)
        {
            _table = table;
            _connectionString = connectionString;
        }

        public SqlCreateBuilder Column(string name, string attributes)
        {
            _columns.Add($"{name} {attributes}");
            return this;
        }

        public void Execute()
        {
            if (_columns.Count <= 0)
                throw new InvalidOperationException("At least one column must be defined.");

            string sql = $"CREATE TABLE {_table}({string.Join(", ", _columns)})";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
