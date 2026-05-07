namespace EaseStay.Core.Database
{
    internal class Database
    {
        private string _connectionString;

        public Database(string connectionString)
        {
            _connectionString = connectionString;
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
