namespace CalculatorApp.CalculationLogic
{
    public class Calculation
    {
        //a special method without any return type
        //it is called during object creation
        //it's job is to assign default or user values to data members of the class
        //constructor name must be same as that of the class name        
        //public Calculation()
        //{
            
        //}
        public int Add(int x, int y)
        {
            return x + y;
        }

        //expression body syntax of writing methods
        //function signature => function body
        public int Subtract(int x, int y) => x - y;

        //public void Multiply(int x, int y) => Console.WriteLine(x * y);
        public int Multiply(int x, int y) => (x * y);

        public int Divide(int x, int y) => y != 0 ? x / y : throw new DivideByZeroException("divisor can not be zero");

    }
}
