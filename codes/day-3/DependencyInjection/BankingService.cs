namespace DependencyInjection
{
    public class BankingService : IBankingService
    {
        //has-a relationship
        private readonly IOperations operations;

        //public BankingService() { 
        //    _bankingOperations = new BankingOperations();
        //}

        public BankingService(IOperations operations)
        {
            this.operations = operations;
        }

        public bool Transfer(int debitAccId, int creditAccId, decimal amount)
        {
            //Operations operations = new BankingOperations();
            bool status = operations.Debit(debitAccId, amount);
            if (status)
            {
                return operations.Credit(creditAccId, amount);
            }
            return false;
        }
    }
}
