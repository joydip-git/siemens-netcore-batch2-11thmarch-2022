namespace AbstractApp
{
    internal class OracleDataAccess : DataAccess
    {
        public OracleDataAccess()
        {
            
        }
        public OracleDataAccess(string connection):base(connection) 
        {
            
        }
        public override void OpenConnection() { }
        public override void CloseConnection() { }
        public override string GetData() { return ""; }
    }
}
