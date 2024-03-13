namespace DependencyInjection
{
    //abstract internal class Operations
    interface IOperations
    {
        bool Credit(int creditAccId, decimal amount);
        bool Debit(int debitAccId, decimal amount);
    }
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
    class BankingOperations : Operations
    {

    }
}
