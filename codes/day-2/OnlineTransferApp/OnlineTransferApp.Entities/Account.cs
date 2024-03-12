namespace OnlineTransferApp.Entities
{
    public class Account
    {
        #region Data Members
        string? accountHolderName;
        readonly int accountId;
        decimal currentBalance;
        readonly static decimal minimumBalance;
        readonly static decimal withdrawalLimit;
        #endregion

        #region Constructors
        static Account()
        {
            minimumBalance = 500;
            withdrawalLimit = 15000;
        }
        public Account()
        {

        }
        public Account(int accountId, string? accountHolderName, decimal currentBalance)
        {
            this.accountHolderName = accountHolderName;
            this.accountId = accountId;
            this.currentBalance = currentBalance;
        }
        #endregion

        #region Properties
        public int AccountId => accountId;
        public static decimal MinimumBalance => minimumBalance;
        public static decimal WithdrawalLimit => withdrawalLimit;

        public string? AccountHolderName { get => accountHolderName; set => accountHolderName = value; }        
        public decimal CurrentBalance { get => currentBalance; private set => currentBalance = value; }
       
        #endregion

        #region Methods
        public bool CreditAmount(decimal amount)
        {
            this.CurrentBalance += amount;
            return true;
        }
        public bool DebitAmount(decimal amount)
        {
            if (amount > 0)
            {
                if (amount < currentBalance)
                {
                    if (amount < withdrawalLimit)
                    {
                        decimal temp = currentBalance - amount;
                        if (temp < minimumBalance)
                        {
                            throw new Exception($"the minimum balance will not be maintained if this transfer happens");
                        }
                        else
                        {
                            this.currentBalance -= amount;
                            return true;
                        }
                    }
                    else
                    {
                        throw new Exception($"You have entered amount more than your withdrawal limit");
                    }
                }
                else
                    throw new Exception($"You have entered amount more than your current balance");
            }
            else
                throw new Exception($"You have entered amount less than or equal to zero");
        }
        #endregion
    }
}
