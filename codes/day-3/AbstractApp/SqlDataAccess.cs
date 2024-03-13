namespace AbstractApp
{
    internal class SqlDataAccess:DataAccess
    {
        public SqlDataAccess()
        {

        }
        public SqlDataAccess(string connection) : base(connection)
        {

        }
        public override void OpenConnection() { }
        public override void CloseConnection() { }
        public override string GetData() { return ""; }
    }
}
