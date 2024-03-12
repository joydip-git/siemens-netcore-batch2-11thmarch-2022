using OOP.Entities;

namespace OOP { 
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to OOP");
            //variable declaration (no object is being created at this point)
            //the "person" variable stores no reference as of now
            Person? person = null;

            //creating instance of the Person class by calling the constructor (Default)
            //and storing the reference of that instance in the "person" variable
            //Note: memory block allocation for the instance members are in heap
            //and the memory allocation for the reference variable (person) is in stack 

            //new keyword is an instruction to runtime for instantiation of Person class
            //runtime will look into the definition of Person class and discover the data memmbers.
            //Next, runtime will allocate the memory blocks for the values of the data memebers to be stored in the heap.
            //Next the constructor of the class (whichever you have invoked in your code) will be invoked and values (default or user values, depending on which constructor has been invoked, either default or parameterized) will be assigned to the memory blocks for the data members.
            //After that, runtime will return the initial address of the instance in the heap memory and the same will be stored in the variable of Person class in stack.
            //person = new Person();
            //person = new Person("anil", 34, "Bangalore");
            //person = new Person("anil", 34);

            //person = new Person("anil", "Chennai"); <-- is incorrect

            //named arguments (passing the value for an argument of a method, by using the name of the argument followed by the value) (C# 4.0)
            person = new Person(location: "Chennai", name: "anil");
            //person.name = "sunil"; <-- incorrect approach (internal, like a private)
            person.age = 20;//public
            Console.WriteLine(person.GetInfo());
        }
    }
}