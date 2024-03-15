namespace EmployeeServiceWebAPI.Repository
{
    public class EmployeeInfo
    {
        public int Id { get; set; }
        public required string EmpName { get; set; }
        public required decimal EmpSalary { get; set; }
        public string? Emp_Dept { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{EmpName}, Salary:{EmpSalary}, Department:{Emp_Dept}";
        }
    }
}
