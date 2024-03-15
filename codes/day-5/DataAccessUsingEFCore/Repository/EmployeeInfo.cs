//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessUsingEFCore.Repository
{
    /*
    [Table("employeerecords")]
    public class EmployeeInfo
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [Column("name",TypeName ="varchar(50)")]
        public required string EmpName { get; set; }

        [Required]
        [Column("salary", TypeName = "decimal(18,2)")]
        public required decimal EmpSalary { get; set; }

        [Column("department", TypeName = "varchar(20)")]
        public string? Emp_Dept { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{EmpName}, Salary:{EmpSalary}, Department:{Emp_Dept}";
        }
    }*/
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
