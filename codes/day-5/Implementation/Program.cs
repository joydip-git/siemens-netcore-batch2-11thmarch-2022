namespace Implementation
{
    internal class Program
    {
        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }
        static bool IsOdd(int x)
        {
            return x % 2 != 0;
        }
        static List<int> Filter(List<int> inputList, Func<int, bool> logicDel)
        {
            var resultList = new List<int>();
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
            Func<int, bool> isEvenDel = IsEven;
            Func<int, bool> isOddDel = IsOdd;

            var result = Filter(list, isEvenDel);
            //var result = Filter(list, isOddDel);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
