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
        int? result = Calculate(calculationObjectReference, choice, firstValue, secondValue);
        if (result.HasValue)
            //Console.WriteLine(result.Value);
            Console.WriteLine(result);
        else
            Console.WriteLine("incorrect choice");

        //decision = ChangeDecision();
        Change(ref decision);
    } while (decision != 'n');
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex);
}
catch (FormatException ex)
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
    //string? strChoice = Console.ReadLine(); //strChoice = null;
    string strChoice = Console.ReadLine() ?? "";
    //if (strChoice != null)
    if (strChoice != "")
    {
        return int.Parse(strChoice);
    }
    else
        throw new FormatException("invalid format data instead of proper choice");
}

static int GetValue()
{
    Console.Write("Enter Value: ");
    //string? strValue = Console.ReadLine();
    string strValue = Console.ReadLine() ?? "";
    //if (strValue != null)
    if (strValue != "")
    {
        return int.Parse(strValue);
    }
    else
        throw new FormatException("invalid format data instead of proper value entered");
}

static int? Calculate(Calculation calculation, int choice, int first, int second)
{
    //int result = null; <-- you can't store null in value types
    //Nullable value type => a type which can store null or proper value of value type
    //Nullable<int> result = null;
    int? result = null;
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

        default:
            result = null;
            break;
    }

    return result;
}

/*
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
*/

//local functions can not be overloaded
static void Change(ref char choice)
{
    Console.Write("enter n to terminate or anythong else to continue: ");
    string strChoice = Console.ReadLine() ?? "";
    if (strChoice != "")
    {
        choice = char.Parse(strChoice);
        if (char.IsUpper(choice))
            choice = char.ToLower(choice);
    }
}
#endregion
