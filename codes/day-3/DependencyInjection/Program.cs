namespace DependencyInjection
{
    internal class Program
    {
        static void Main()
        {
            IOperations operations = new BankingOperations();
            BankingService service = new BankingService(operations);
            service.Transfer(100, 200, 1000);
        }
    }
}
