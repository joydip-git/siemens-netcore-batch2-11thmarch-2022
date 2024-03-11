namespace App
{
    
    class Person
    {
        public string name = "";
        public int age;
    }
    internal class Program
    {
        //static void Main(string[] args)
        //static int Main(string[] args) { return 0;}
        //static int Main() { return 0;}
        static void Main()
        {
            //int => value type data type
            //a => value type variable
            int data = 100;
            Console.WriteLine("Hello, World! " + data);

           

            Check();

            int first = 12;
            int second = 10;
            if (first > second)
            {
                Console.WriteLine("first is greater");                
            }
            else
                Console.WriteLine("second is greater");

            while (first > 6)
            {
                Console.WriteLine(first);
                first--;
            }

            do
            {
                Console.WriteLine(second);
                second--;
            } while (second>7);

            int choice = 1;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("");
                    break;

                case 2:
                    break;

                default:
                    Console.WriteLine();
                    break;
            }

            //creates an instance of Array class in runtime to store exactly one reference of a person object
            Person[] people= new Person[1];

            //creating a Person class object
            //Person class => reference types data type
            //joydipObjectReference => reference variable
            Person joydipObjectReference = new Person();

            //Passing the values
            joydipObjectReference.name = "Joydip";
            joydipObjectReference.age = 10;

            //in the arry instance storing reference of a person object
            people[0]=joydipObjectReference;

            int[] numbers = new int[3];
            //numbers[0] = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("enter a value");
                string str = Console.ReadLine();
                //Convert class's ToInt32 method can convert any (if possible) type of value to Int32 or int type
                //int value = Convert.ToInt32(str);
                //Parse method converts always string value into something
                int value = int.Parse(str);
                numbers[i] = value;               
            }
            //iterator (or enumerator)
            //during enumeration DO NOT alter the original source of data
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        static void Check()
        {
            int first = 10;
            Console.WriteLine(first);
        }
    }
}
