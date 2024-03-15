namespace DependencyInjection
{
    //abstract internal class Operations
    public interface IOperations
    {
        bool Credit(int creditAccId, decimal amount);
        bool Debit(int debitAccId, decimal amount);
    }
    /*
    abstract internal class Operations : IOperations
    {
        public bool Credit(int creditAccId, decimal amount)
        {
            return true;
        }
        public bool Debit(int debitAccId, decimal amount)
        {
            return true;
        }
    }
    */
    //public class BankingOperations : Operations
    public class BankingOperations : IOperations
    {
        public bool Credit(int creditAccId, decimal amount)
        {
            return true;
        }
        public bool Debit(int debitAccId, decimal amount)
        {
            return true;
        }
    }
}
