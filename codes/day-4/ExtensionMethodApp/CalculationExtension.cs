namespace ExtensionMethodApp
{
    public static class CalculationExtension
    {
        public static int Subtract(this ICalculation calculation, int a, int b)
        {     
            return a - b;
        }
    }
}
