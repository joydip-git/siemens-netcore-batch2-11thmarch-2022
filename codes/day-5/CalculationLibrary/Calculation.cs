namespace CalculationLibrary
{
    public class Calculation : ICalculation
    {
        public int Result { get; private set; } = 0;
        public void Add(int a, int b)
        {
            Result = a + b;
        }
    }
}
