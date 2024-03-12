using OnlineTransferApp.Entities;

namespace OnlineTransferApp.UserInterface
{
    internal class Program
    {
        static Account CreateAccount()
        {            
            Console.Write("enter name: ");
            string name = Console.ReadLine() ?? throw new FormatException("Incorrect format");
            Console.Write("enter id: ");
            int accId = int.Parse(Console.ReadLine() ?? throw new FormatException("incorrect format"));
            Console.Write("enter current balance: ");
            decimal current = decimal.Parse(Console.ReadLine() ?? throw new FormatException("incorrect format"));

            Account account = new Account(accId,name,current);
            return account;
        }
        static decimal AskForTransferAmount()
        {
            Console.WriteLine("enter amount to transfer");
            decimal amount = decimal.Parse(Console.ReadLine() ?? throw new FormatException("incorrect format"));
            return amount;
        }
        static void Transfer(Account debitAcc, Account creditAcc)
        {
            decimal amount = AskForTransferAmount();
            bool debitStatus = false;
            debitStatus = debitAcc.DebitAmount(amount);
            if (debitStatus)
            {
                creditAcc.CreditAmount(amount);
                Console.WriteLine("amount is successfully transfered");
            }
        }
        static void Main()
        {
            try
            {
                Account creditAccount = CreateAccount();
                Account debitAccount = CreateAccount();
                Transfer(debitAccount, creditAccount);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
