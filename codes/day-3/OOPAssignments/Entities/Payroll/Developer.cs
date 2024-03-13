namespace Entities.Payroll
{
    public class Developer : Employee
    {
        private double incentivePay;
        public Developer()
        {

        }

        public Developer(int id, string name, double basicPay, double daPay, double hraPay, double incentivePay) : base(id, name, basicPay, daPay, hraPay)
        {
            this.incentivePay = incentivePay;
        }

        public double IncentivePay
        {
            get { return incentivePay; }
            set { incentivePay = value; }
        }

        public override double CalculateSalary()
        {
            return base.CalculateSalary() + incentivePay;
        }
    }
}
