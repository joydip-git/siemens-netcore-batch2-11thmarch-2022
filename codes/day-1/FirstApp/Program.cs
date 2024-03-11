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
