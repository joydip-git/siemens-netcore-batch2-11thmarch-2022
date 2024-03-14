namespace GenericApp
{
    interface IGeneric<T>
    {
        void Add(T item);
    }
    internal class GenericCls<T> : IGeneric<T> where T : new()
    {
        public GenericCls() { }
        public GenericCls(T obj) { }
        public void Add(T obj) { }
    }
}
