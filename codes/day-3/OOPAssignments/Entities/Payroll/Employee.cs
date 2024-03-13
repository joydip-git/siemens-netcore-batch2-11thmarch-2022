namespace Entities.Payroll
{
    public class Employee
    {
        private readonly int id;
        private string name = "";
        private double basicPay;
        private double daPay;
        private double hraPay;

        public Employee()
        {

        }

        public Employee(int id, string name, double basicPay, double daPay, double hraPay)
        {
            this.id = id;
            this.name = name;
            this.basicPay = basicPay;
            this.daPay = daPay;
            this.hraPay = hraPay;
        }

        public double HraPay
        {
            get { return hraPay; }
            set { hraPay = value; }
        }
        public double DaPay
        {
            get { return daPay; }
            set { daPay = value; }
        }
        public double BasicPay
        {
            get { return basicPay; }
            set { basicPay = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
        }
        public virtual double CalculateSalary()
        {
            return basicPay + daPay + hraPay;
        }
    }
}
