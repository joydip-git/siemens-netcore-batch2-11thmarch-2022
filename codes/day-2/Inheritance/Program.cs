namespace Inheritance
{
    internal class Program
    {
        static void Main()
        {
            //runtime will allocate memory blocks for all data members, including the data members from both the child as well as base class
            //also runtime will invoke default ctor of base class along with child class any constructor (whichever you are invoking)
            //Maruti brezza = new Maruti();
            Maruti brezza = new Maruti("New Brezza", "abce1234", "Red", true, true);
            
        }
    }
}
