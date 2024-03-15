using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main()
        {
            //version 1: using my own factory for dependency injection
            //IOperations operations = new BankingOperations();
            //BankingFactory factory = new BankingFactory();
            //BankingFactory factory = BankingFactory.InstantiateFactory();
            //IOperations operations = factory.Create<IOperations,BankingOperations>();
            //BankingService service = new BankingService(operations);
            //service.Transfer(100, 200, 1000);

            //version 2: using dependency injection framework provided by .NET
            //container to store dependency class instances
            IServiceCollection servicesContainer = new ServiceCollection();

            //registering which type of service instances should be created and maintained in the container
            //also you have to register a service provider for all services of the container or multiple service provider for individual service of the container
            IServiceProvider provider = 
                servicesContainer
                 .AddSingleton<IOperations, BankingOperations>()
                 .AddSingleton<IBankingService, BankingService>()
                 .BuildServiceProvider();

            //ask the provider for instance of class implementing IOperations interface
            //var operations = provider
            //    .GetRequiredService<IOperations>();
            //BankingService bankingService = new BankingService(operations);

            //directly ask for IBankingService type object
            //while instanting IBankingService type of object, DI framework will resolve the dependency of IBankingService type on IOperations type and will instance automatically the IOperations type
            //and will dependency inject the instance of IOperations type into the instance of IBankingService type

            var bankingService = provider.GetRequiredService<IBankingService>();
            bankingService.Transfer(100, 200, 1000);

        }
    }
}
