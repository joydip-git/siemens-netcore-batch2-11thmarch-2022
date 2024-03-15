namespace Implementation
{
    class Person
    {
        public bool Get(int a) => a < 5;
        public string Name => "joydip";
    }
    internal class Program
    {
        bool IsEven(int x)
        {
            return x % 2 == 0;
        }
        static bool IsOdd(int x)
        {
            return x % 2 != 0;
        }
        //which source of data to filter (List<int> => object)
        //how to filter that source of data(logic => function/method)
        //static List<int> Filter(List<int> inputList, Func<int, bool> logicDel)
        static IEnumerable<T> Filter<T>(IEnumerable<T> inputList, Func<T, bool> logicDel)
        {
            var resultList = new List<T>();
            foreach (var item in inputList)
            {
                //if (item % 2 != 0)
                var isTrue = logicDel(item);
                if (isTrue)
                    resultList.Add(item);
            }
            return resultList;
        }
        static void Main()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //Func<int, bool> isEvenDel = new Func<int, bool>(IsEven);
            Func<int, bool> isEvenDel = new Program().IsEven;
            Func<int, bool> isOddDel = IsOdd;

            Func<int, bool> isGreaterThanFourDel = new Func<int, bool>(
                //static bool IsGreater(int x)
                //anonymous method
                delegate (int x)
                {
                    return x > 4;
                }
            );
            //Func<int, bool> lessThanFiveDel = delegate (int a)
            //{
            //    return a < 5;
            //};

            //writing anonymous method using expression body syntax
            //this expression bodied syntax to represent an anonymous method is known as: Lambda Expression
            //Func<int, bool> lessThanFiveDel = (int a) => a < 5;
            //here data type of "a" is automatically "inferred" from the delegate signature
            //since "int" represents data type of <in T> of delegate signature, the data type of "a" is inferred as "int"
            Func<int, bool> lessThanFiveDel = (a) => a < 5;

            //var result = Filter(list, isEvenDel);
            //var result = Filter(list, isOddDel);
            //var result = Filter(list, isGreaterThanFourDel);
            var result = Filter(list, lessThanFiveDel);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<string> names = new List<string>
            {
                "sunil","anil","amit","joydip","suresh"
            };

            Func<string, bool> filterNameDel = (name) => name[0] == 's';
            var filteredNames = Filter(names, filterNameDel);
            Action<string> printName = (name) => Console.WriteLine(name);
            filteredNames
            .ToList()
            .ForEach(printName);
        }
    }
}
