namespace PolymorphismApp
{
    internal class Program
    {
        //method overloading
        static void Add(int a, int b)
        {

        }
        static void Add(int a, int b, int c)
        {

        }
        static void Add(int a, int b, long c)
        {

        }
        static void Add(int a, long b, int c)
        {

        }

        static void Main()
        {
            //function invocation
            Add(1, 2);
            Add(2, 3, 4);
            Add(3, 4, 123456789123);
            Add(3, 123456789123, 5);

            int x = 10;
            int y = 20;
            if (x == y)
            {
                Console.WriteLine("same");
            }
            else
                Console.WriteLine("not same");

            Person anilPerson = new Person("anil", 1);
            Person other = new Person("anil", 1);
            //Person other = anilPerson;

            //checking whether both the reference variables are storing address of same object or not. It does not matter, both the objects have same value for name and id or not.
            if (anilPerson == other)
            {
                Console.WriteLine("same");
            }
            else
                Console.WriteLine("not same");

            // Flamingo flamingo = new Flamingo();
            // flamingo.MakeSound();

            //up-casting: storing the reference of a child class object in a variable of it's base class
            //by default through this reference variable of base class, you will be able to access members of base class present in child class object
            //possible because, the members of base are also present in child class object, hence you can invoke the base members inherited and present from the child class object
            //Bird flamingo = new Flamingo();
            //flamingo.MakeSound(); //by default compiler decides to call the MakeSound from base class, because he reference variable is of type base class

            //Flamingo bird = new Bird();<= not posible because no member of child class will be present in base class object (InvalidCastException)

            //Parrot parrot = new Parrot();
            //Bird parrot = new Parrot();
            //parrot.MakeSound();

            Bird? bird = null;
            Console.Write("enter 1 for Flamingo and 2 for Parrot and 3 for Irish Flamingo: ");
            int choice = int.Parse(Console.ReadLine()??throw new FormatException("Incorrect format"));
            switch (choice)
            {
                case 1:
                    bird = new Flamingo();
                    break;

                case 2:
                    bird = new Parrot();
                    break;

                case 3:
                    bird = new IrishFlamingo();
                    break;

                default:
                    break;
            }
            Invoke(bird);
            //Flamingo flamingo = new Flamingo();
            //Invoke(flamingo);

            //Parrot parrot = new Parrot();
            //Invoke(parrot);
        }
        static void Invoke(Bird? bird)
        {
            //by default compiler decides to call the MakeSound from Bird class, because at this moment untill runtime it is not clear which refernce is stored in the argument "bird"
            bird?.MakeSound();
        }
        //static void Invoke(Flamingo flamingo)
        //{
        //    flamingo.MakeSound();
        //}
        //static void Invoke(Parrot parrot)
        //{
        //    parrot.MakeSound();
        //}
    }
}
