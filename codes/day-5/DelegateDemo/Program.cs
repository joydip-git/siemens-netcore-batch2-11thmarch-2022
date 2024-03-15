namespace DelegateDemo
{
    internal class Program
    {
        static void Main()
        {
            Calculation calculation = new Calculation();
            //calculation.Add(1, 2);

            //2. create instance of the CalDel to store reference of Add method of Calculation class
            //the reference of the method must be passed to the constructor of the delegate
            //name of the method acts as the reference
            // if the method is an instance method pass the reference of the method along with the reference to the object of that class
            //CalDel addDel = new CalDel(calculation.Add);
            //CalDel<int> addDel = new CalDel<int>(calculation.Add);
            CalDel<int, int> addDel = new CalDel<int, int>(calculation.Add);

            // if the method is a static method pass the reference of the method along with the name of that class
            //CalDel subDel = new CalDel(Calculation.Subtract);
            //CalDel<int> subDel = new CalDel<int>(Calculation.Subtract);
            CalDel<int, int> subDel = new CalDel<int, int>(Calculation.Subtract);

            //3. invoke the method using the delegate
            //if the method demands any parameter, pass them to the delegate
            //if the method returns any value, delegate will return that value to you
            //addDel(12, 13);
            //subDel(12, 3);
            Console.WriteLine(addDel(12, 13));
            Console.WriteLine(subDel(12, 3));

            //Action delegate is used to call such method(s), whose return type is always "void" and number of arguments can be maximum upto 16 of any type
            Action<int> printDel = new Action<int>(Program.Print);
            printDel(12);

            //Predicate delegate is used to call such method(s), whose return type is always "bool" and accepts just one argument of any type
            Predicate<int> isEvenDel = new Predicate<int>(Program.IsEven);
            Console.WriteLine(isEvenDel(13) ? "even" : "odd");

            //Func delegate can be used to call variety of methods, where you can define both return type as well input type and can take from 0 upto maximum 16 arguments of any type and must have a rteurn type which is not "void"
            //note: this delegate can't camm any method with return type void
            //Func<string> helloDel = new Func<string>(GetMessage);
            Func<string, string> helloDel = new Func<string, string>(GetMessage);
            Console.WriteLine(helloDel("joydip"));
            Func<int, bool> isOddDel = new Func<int, bool>(IsOdd);
            Console.WriteLine(isOddDel(14) ? "odd" : "even");

        }
        static string GetMessage(string name)
        {
            return "hello..." + name;
        }
        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }
        static bool IsOdd(int x)
        {
            return x % 2 != 0;
        }
        static void Print(int x)
        {
            Console.WriteLine(x);
        }
    }
}
