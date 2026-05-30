using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace EaseStay.Core.Database
{
    internal class SqlUpdateBuilder
    {
        private readonly string _connectionString;
        private readonly string _table;

        private readonly Dictionary<string, object> _setValues =
            new Dictionary<string, object>();

        private string _whereColumn;
        private string _whereOperator;
        private object _whereValue;

        public SqlUpdateBuilder(string table, string connectionString)
        {
            _table = table;
            _connectionString = connectionString;
        }

        public SqlUpdateBuilder Set(string column, object value)
        {
            _setValues[column] = value;
            return this;
        }

        public SqlUpdateBuilder Where(string column, string op, object value)
        {
            _whereColumn = column;
            _whereOperator = op;
            _whereValue = value;

            return this;
        }

        public void Execute()
        {
            if (_setValues.Count == 0)
                throw new InvalidOperationException("No values defined for update.");

            if (string.IsNullOrEmpty(_whereColumn))
                throw new InvalidOperationException("WHERE clause is required.");

            string setClause = string.Join(", ",
                _setValues.Keys.Select(c => $"{c} = @set_{c}"));

            string sql =
                $"UPDATE {_table} " +
                $"SET {setClause} " +
                $"WHERE {_whereColumn} {_whereOperator} @whereValue";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                foreach (var item in _setValues)
                {
                    cmd.Parameters.AddWithValue(
                        "@set_" + item.Key,
                        item.Value ?? DBNull.Value
                    );
                }

                cmd.Parameters.AddWithValue(
                    "@whereValue",
                    _whereValue ?? DBNull.Value
                );

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}