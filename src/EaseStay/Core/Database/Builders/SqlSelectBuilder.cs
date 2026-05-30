using System.Collections.Generic;
using System.Data.SqlClient;

namespace EaseStay.Core.Database
{
    internal class SqlSelectBuilder
    {
        private string _connectionString;
        private string _table;

        private string[] _columns;
        private string _whereColumn;
        private string _whereOperator;
        private object _whereValue;

        public SqlSelectBuilder(string table, string connectionString)
        {
            _table = table;
            _connectionString = connectionString;
        }

        public SqlSelectBuilder Columns(params string[] columnsName)
        {
            _columns = columnsName;
            return this;
        }

        public SqlSelectBuilder Where(string column, string op, object value)
        {
            _whereColumn = column;
            _whereOperator = op;
            _whereValue = value;

            return this;
        }

        public List<Dictionary<string, object>> Execute()
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

            string columns = (_columns == null || _columns.Length == 0)
                ? "*"
                : string.Join(",", _columns);

            string sql = $"SELECT {columns} FROM {_table}";

            if (!string.IsNullOrEmpty(_whereColumn))
                sql += $" WHERE {_whereColumn} {_whereOperator} @{_whereColumn}";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (!string.IsNullOrEmpty(_whereColumn))
                    cmd.Parameters.AddWithValue("@" + _whereColumn, _whereValue);

                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var row = new Dictionary<string, object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                            row[reader.GetName(i)] = reader.GetValue(i);

                        result.Add(row);
                    }
                }
            }

            return result;
        }
    }
}
