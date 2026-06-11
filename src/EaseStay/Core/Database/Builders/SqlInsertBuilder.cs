using System;
using System.Linq;
using System.Data.SqlClient;

namespace EaseStay.Core.Database.Builders
{
    internal class SqlInsertBuilder
    {
        private readonly string _connectionString;
        private readonly string _table;

        private string[] _columns;
        private object[] _values;

        public SqlInsertBuilder(string table, string connectionString)
        {
            _table = table;
            _connectionString = connectionString;
        }

        public SqlInsertBuilder Columns(params string[] columnsName)
        {
            _columns = columnsName;
            return this;
        }

        public SqlInsertBuilder Values(params object[] values)
        {
            _values = values;
            return this;
        }

        public void Execute()
        {
            if (_columns == null || _values == null)
                throw new InvalidOperationException("Columns and Values must be defined.");

            if (_columns.Length != _values.Length)
                throw new InvalidOperationException("Columns and Values count mismatch.");

            string columns = string.Join(",", _columns);
            string parameters = string.Join(",", _columns.Select(c => "@" + c));

            string sql = $"INSERT INTO {_table} ({columns}) VALUES ({parameters})";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                for (int i = 0; i < _columns.Length; i++)
                {
                    cmd.Parameters.AddWithValue("@" + _columns[i], _values[i]);
                }

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
