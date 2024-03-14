using CalculationLibrary;

namespace ExtensionLibrary
{
    //using extension method technique you can't add any static method in existing type
    //the extension class must be a static class
    public static class CalculationExtension
    {
        //extend the existing Calculation class by including this method as an instance method in existing Calculation class, without modifying the source code of existing Calculation class
        public static int Subtract(this Calculation calc, int a, int b)
        {
            return a - b;
        }
    }
}
