namespace Entities.Payroll
{
    public class Hr : Employee
    {
        private double gratuityPay;

        public Hr() { }

        public Hr(int id, string name, double basicPay, double daPay, double hraPay, double gratuityPay) : base(id, name, basicPay, daPay, hraPay)
        {
            this.gratuityPay = gratuityPay;
        }

        public double GratuityPay
        {
            get { return gratuityPay; }
            set { gratuityPay = value; }
        }
        public override double CalculateSalary()
        {
            return base.CalculateSalary() + gratuityPay;
        }
    }
}
