//feature: top-level statement
//it hides the explicit Main method and the class to which the main method belongs

//Top-level statement is not being used here
//namespace FirstApp
//{
//    class Program
//    {
//        //string[] args => array declaration
//        //this array is used to accept command line arguments
//        static void Main(string[] args)
//        {
//            Print();
//            Show();

//            //local variable (x)
//            int x = 10;
//            //inner function
//            //local function (Show)
//            void Show()
//            {
//                Console.WriteLine("Show method ");
//            }
//        }
//        separate function
//        static void Print()
//        {
//            Console.WriteLine("Welcome to .NET 8 and CSharp");
//        }
//    }
//}
/*
//using Microsoft.Extensions.DependencyInjection;
using SampleLibraryApp;

//using Top-level statement style
Console.WriteLine("Welcome to .NET 8 and CSharp");

Show();
//is Show a separate function or local function??
void Show()
{
    Console.WriteLine("Show method");
    Messenger messenger = new Messenger();
    string result = messenger.SendMessage("joydip");
    Console.WriteLine(result);
}
*/
class A
{
    protected static int x;

    public static int X { get => x; set => x = value; }
}
class B : A
{
    public void Show()
    {
        System.Console.WriteLine($"X: {x}");
    }
}
public interface IOperations
{

}
public static class OperationExtension
{
    public int Add(this IOperations operations, int x, int y)
    {
        return x + y;
    }
}
class Program
{
    static void Main()
    {
        HashSet<Product> products = new HashSet<Product>();
        Product first = new Product { Id = 1, Name = "Product1" };
        Product second = new Product { Id = 2, Name = "Product2" };
        Product third = first;
        third.Name = "Product3";
        products.Add(first);
        products.Add(second);
        products.Add(third);

        foreach (var product in products)
        {
            System.Console.WriteLine(product.Name);
        }
    }
}
