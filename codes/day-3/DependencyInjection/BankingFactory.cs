namespace DependencyInjection
{
    public class BankingFactory
    {
        private static BankingFactory? instance;

        private BankingFactory() { }

        public static BankingFactory InstantiateFactory()
        {
            if(instance == null)
                instance = new BankingFactory();

            return instance;
        }

        private List<Object> instances = new List<Object>();

        public TInterface Create<TInterface,TClass>() 
            where TInterface : class
            where TClass:TInterface
        {
            //Type tClass = typeof(TClass);
            //var tClassObj = Activator.CreateInstance(tClass);
            var tClassObj = Activator.CreateInstance<TClass>();
            instances.Add(tClassObj);
            return (TInterface)tClassObj;
        }
    }
}
