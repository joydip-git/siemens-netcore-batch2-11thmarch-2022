using System.Xml.Linq;

namespace OOP.Entities
{
    public class Person
    {
        //instance members
        //readonly => the value of this type of data member can be set via a constructor ONLY
        private readonly int id;
        //internal string? name;
        private string? name;
        //public int age;
        private int age;
        private string? location;
        //initializing the data member with some value (field initialization)
        //note: always memory block(s) for static data is/are allocated and initialized first, followed instance data member memory allocation and their initialization
        //private static string companyName = "Siemens";

        //Note: non-readonly (regular) static members values can be set via many ways: static tor, field initialization, instance ctors, methods etc.
        //the value of this readonly static data can be set via a static ctor ONLY
        private static readonly string? companyName = "";

        //no access specifier
        //can access ONLY static members of the class
        //no instance member can be accessed from here
        //this ctor is executed ONLY once, generally during the creation of first instance of the class, before all other constructors
        //this constructor is called immediately after allocation of memory blocks for all static data members ONLY
        //this ctor is called implicitly by runtime
        //user can't call this ctor explicitly from outside the class
        //hence this ctor can't be overloaded/parameterized
        static Person()
        {
            companyName = "Siemens";
            Console.WriteLine($"only once called and the value placed in companyName is {companyName}");
        }

        //static method
        //public static void SetCompanyname(string? company)
        //{
        //    companyName = company;
        //}

        //constructor is called DURING object creation, neither before nor after object creation
        //constuctor NEVER returns anything, hence no return type for constructor

        //default constructor
        public Person()
        {
            //name= string.Empty;
            //location = "";
            //age = 0;
            //companyName = "Siemens";
            Console.WriteLine("default ctor of Person");
        }
        //parametrized constructor
        //optional arguments with default values (C# 4.0)
        //optional arguments should be the last of in the argument list, i.e., they should appaer after all the required arguments
        public Person(int id, string? name, int age = 0, string? location = "Bangalore")
        {
            this.id = id;
            this.name = name;
            this.location = location;
            this.age = age;
            //static member (data) is NOT accessed by "this" keyword, since this data is not part of any object in particular, rather shared across objects/instances of this class. Hence every object has direct access to it
            //companyName = companyName;
            Console.WriteLine("parameterized ctor of Person");
        }

        //expression body style/syntax
        //access-specifier return-type method-name(argumnets list)
        public string GetInfo() =>
            $"Id: {id}, Name: {name}, Age: {age}, Location:{location}, Company Name:{companyName}";

        //pair of getter and setter methods
        // public int GetId() => id;

        //property for Id
        //public int Id
        //{
        //    get => id;
        //}

        //expression body syntax for read only property
        public int Id => id;

        //public string? GetName() => name;
        //public void SetName(string? value) => this.name = value;

        //proerty (encapsulator of setter and getter methods for a data member)
        //behind the scene the set and get accesors represent two methods
        //data type of the property is decided by the data type of the data member encapsulated inisd the property's set and get accessors
        public string? Name
        {
            set => name = value; //value => auto-declared local variable (argument of the set method) and only available in "set" accessor, NOT in "get" accessor
            get => this.name;
        }

        //public void SetLocation(string? location) => this.location = location;
        //public string? GetLocation() => location;

        public string? Location
        {
            set => location = value;
            get => this.location;
        }

        //public void SetAge(int age) => this.age = age;
        //public int GetAge() => age;

        //public int Age
        //{
        //    set => age = value;
        //    get => age;
        //}

        //write-only Age property
        public int Age
        {
            set => age = value;
        }

        //there is no expression bidy syntax for write only property as the "value" (auto-declared variable) can be used in explicit "set" acessor
        //public int Age => age = value;
    }
}
