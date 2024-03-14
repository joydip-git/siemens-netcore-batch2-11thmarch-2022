namespace ExtensionMethodApp
{
    internal class Program
    {
        static void Main()
        {
            CalculationInitial calculationInitial = new CalculationInitial();
            Console.WriteLine(calculationInitial.Add(12, 3));
            //extension method
            Console.WriteLine(calculationInitial.Subtract(12, 3));

            CalculationUpgraded calculationUpgraded = new CalculationUpgraded();
            Console.WriteLine(calculationUpgraded.Add(12, 3));
            Console.WriteLine(calculationUpgraded.Multiply(12, 3));
            //extension method
            Console.WriteLine(calculationUpgraded.Subtract(12, 3));

            var list = new List<int>
            {
                1,2,3,4
            };
            Console.WriteLine(list.Any() ? "yes" : "no");
        }
    }
}
