namespace AbstractApp
{
    internal interface IOperations
    {
        void Add(int x, int y);
        int Result { get; }
    }
    abstract class PartialOperation : IOperations
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        //private int Result { get; }
        public abstract int Result { get; }
    }
    class Operations : IOperations
    {
        int _result;
        public void Add(int x, int y)
        {
            _result = x + y;
        }
        public int Result
        {
            get => _result;
        }
    }
}
