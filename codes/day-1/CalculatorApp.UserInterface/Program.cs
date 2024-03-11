using CalculatorApp.CalculationLogic;

char decision = 'n';
try
{
    do
    {
        PrintChoices();
        int choice = GetChoice();
        int firstValue = GetValue();
        int secondValue = GetValue();
        Calculation calculationObjectReference = new Calculation();
        int result = Calculate(calculationObjectReference, choice, firstValue, secondValue);
        Console.WriteLine(result);

        decision = ChangeDecision();
    } while (decision != 'n');
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

#region local functions
static void PrintChoices()
{
    Console.WriteLine("1. Add\n2. Subtract\n3. Multiply\n4. Divide");
}
static int GetChoice()
{
    Console.Write("Enter Choice[1/2/3/4]: ");
    //Nullable reference type
    //there is possibility that strChoice can store null
    //hence declare the variable as nullable type
    string? strChoice = Console.ReadLine(); //strChoice = null;
    if (strChoice != null)
    {
        return int.Parse(strChoice);
    }
    else
        throw new NullReferenceException("Null reference instead of proper choice");
}
static int GetValue()
{
    Console.Write("Enter Value: ");
    string? strValue = Console.ReadLine();
    if (strValue != null)
    {
        return int.Parse(strValue);
    }
    else
        throw new NullReferenceException("Null reference instead of proper value entered");
}
static int Calculate(Calculation calculation, int choice, int first, int second)
{
    int result = 0;
    switch (choice)
    {
        case 1:
            result = calculation.Add(first, second);
            break;

        case 2:
            result = calculation.Subtract(first, second);
            break;

        case 3:
            result = calculation.Multiply(first, second);
            break;

        case 4:
            result = calculation.Divide(first, second);
            break;
    }

    return result;
}

static char ChangeDecision()
{
    Console.Write("enter n to terminate or anythong else to continue: ");
    //null coalesce operator (??)
    string strChoice = Console.ReadLine() ?? "";
    if (strChoice != "")
    {
        char value = char.Parse(strChoice);
        if (char.IsUpper(value))
            return char.ToLower(value);

        return value;
    }
    else
        return 'n';
}
#endregion
