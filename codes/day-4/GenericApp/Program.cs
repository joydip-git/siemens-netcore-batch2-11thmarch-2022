namespace GenericApp
{
    class Person
    {
        string _name = "";
        public Person()
        {

        }
        public Person(string name)
        {
            _name = name;
        }
    }
    class Author : Person
    {

    }
    internal class Program
    {
        //genetic method with constraint
        //T => type parameter
        static void Add<T>(T a, T b) where T : struct
        {
            object value = default(T);
            Console.WriteLine(value);
        }
        static void Add<Input1, Input2>(Input1 a, Input2 b)
            where Input1 : class
            where Input2 : class
        {

        }
        static void Call<B, C>(B obj1, C obj2)
            where B : class
            where C : B
        {

        }
        static void Some<TRef>(TRef a) where TRef : class?, new()
        {

        }
        static void Check<T>(T a) where T : Person
        {

        }
        static void Main()
        {
            Add<int>(12, 13);
            Add<long>(1261251, 1387752376);
            Add<string, string>("siemens", "bangalore");//Input1 is equal to Input2
            Call<Person, Author>(new Person(), new Author());
            Some<Person>(new Person("anil"));
            Person? p = null;
            Some<Person>(p);
            Check(new Person());
            Check(new Author());

            GenericCls<int> genericCls = new GenericCls<int>();
            GenericCls<Person> people = new GenericCls<Person>();

        }
    }
}
