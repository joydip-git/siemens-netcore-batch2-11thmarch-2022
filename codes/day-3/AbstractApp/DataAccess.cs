namespace AbstractApp
{
    abstract internal class DataAccess
    {
        string? _connectionString;

        public string? ConnectionString { get => _connectionString; set => _connectionString = value; }

        public DataAccess()
        {
            
        }

        public DataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public abstract string GetData();
    }
}
