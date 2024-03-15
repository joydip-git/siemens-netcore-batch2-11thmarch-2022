namespace DependencyInjection
{
    public interface IBankingService
    {
        bool Transfer(int debitAccId, int creditAccId, decimal amount);
    }
}