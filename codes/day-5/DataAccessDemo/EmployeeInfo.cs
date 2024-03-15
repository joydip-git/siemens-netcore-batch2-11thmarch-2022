namespace DataAccessDemo
{
    internal class EmployeeInfo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Salary { get; set; }
        public string? Department { get; set; }
        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Salary:{Salary}, Department:{Department}";
        }
    }
}
