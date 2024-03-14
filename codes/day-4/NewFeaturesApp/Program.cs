using CalculationLibrary;
using ExtensionLibrary;
using static NewFeaturesApp.Sample;

namespace NewFeaturesApp
{
    internal class Program
    {
        //var is not a data type, hence can't be used as return or parameter type of any function
        //static var Get(var x=0)
        //{

        //}

        //var is not a data type, hence can't be used as data type of class members
        //var value;
        static void Main()
        {
            //CalculationExtension.Subtract(calculation,12, 3);

            Calculation calculation = new Calculation();            
            Console.WriteLine(calculation.Add(12,13));
            Console.WriteLine(calculation.Subtract(12,3));
            //local function
            //static void Check()
            void Check()
            {
                SayHello(message: "welcome to new features");
                //strict/strong typing
                int aNum = 20;
                Console.WriteLine(aNum);
                // implicit typing
                // var is a keyword, NOT a data type
                // from the value assigned to the variable the data type will be interpreted (type inference)
                //intNum is an implicitly typed LOCAL VARIABLE
                var intNum = 10;
                //intNum = 12.34D;
                Console.WriteLine(intNum);

                //int[] numbers = [1,2,3,4];
                //int[] numbers = new int[]{1,2,3,4};
                //numbers is an implicitly typed local array variable
                //Note: the array declaration must include values
                var numbers = new[] { 1, 2, 3, 4 };
            }
            Check();

            Person? person = null;

            //person = new Person();
            //person.Name = "anil";
            //person.Id = 1;
            //object intializer
            //person = new Person() { Id = 1, Name = "anil" };

            //if auto properteis are decalred with "required" keyword, then to assign the values you must have to use object initializer technique
            //even passing values through parameterized constructor will not work
            //person = new Person(1, "anil");
            person = new Person { Id = 1, Name = "anil" };



            //if(person != null)
            //{
            //  if(person.Name != null){
            //    Console.WriteLine(person.Name);
            //  }
            //}

            //null propagator or 
            person?.Name?.Concat("jhsa");

            List<string>? list = null;
            //collection initializer
            list = new List<string>
            {
                "anil",
                "sunil",
                "joydip"
            };
            //list.OrderBy(x => x);
            Console.WriteLine(list?[0]);

            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>
            {
                {1,"siemens" },
                {0,"bangalore"},
                {2, "ecity"}
            };

            var data = Test();
            Console.WriteLine($"{data.Item1}, {data.Item2}, {data.Item2}, {data.Item4}");
        }
        static (double, string, char, int) Test()
        {
            //tuple
            var a = 12.34D;
            var b = "siemens";
            var c = 'a';
            var d = 12;

            //(double, string) data = (12.34D, "siemens");
            //Console.WriteLine($"{data.Item1}, {data.Item2}");

            //(double, string, char, int) data = (a, b, c, d);
            var data = (a, b, c, d);
            //Console.WriteLine(data.a);
            return data;
        }
    }
}
