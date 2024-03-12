namespace OOP.Entities
{
    public class Person
    {
        internal string? name;
        public int age;
        private string? location;

        //constructor is called DURING object creation, neither before nor after object creation
        //constuctor NEVER returns anything, hence no return type for constructor
        
        //default constructor
        public Person()
        {
            //name= string.Empty;
            //location = "";
            //age = 0;
        }
        //parametrized constructor
        //optional arguments with default values (C# 4.0)
        //optional arguments should be the last of in the argument list, i.e., they should appaer after all the required arguments
        public Person(string? name, int age = 0, string? location = "Bangalore")
        {
            this.name = name;
            this.location = location;
            this.age = age;
        }

        //access-specifier return-type method-name(argumnets list)
        public string GetInfo()
        {
            //return "Name: " + name + ", Age: " + age + ", Location: " + location;
            //string interpolation
            return $"Name: {name}, Age: {age}, Location:{location}";
        }
    }
}
