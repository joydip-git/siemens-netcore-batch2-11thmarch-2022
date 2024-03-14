namespace Implementation
{
    internal class Program
    {
        //  static IEnumerable<int> Create()
        //  static ICollection<int> Create()
        static IList<int> Create()
        {
            return new List<int>() { 4, 1, 3, 2 };
        }
        static void Main(string[] args)
        {
            IList<int> collection = Create();
            collection.Add(11);
            //collection.Remove(11);
            //collection[0] = 12;
            foreach (int i in collection)
            {
                Console.WriteLine(i);
            }
        }
    }
}
