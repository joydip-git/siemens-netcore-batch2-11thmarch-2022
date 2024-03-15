using Microsoft.EntityFrameworkCore;

namespace EmployeeServiceWebAPI.Repository
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
        public DbSet<EmployeeInfo> EmployeeInfos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API
            modelBuilder
                .Entity<EmployeeInfo>()
                .ToTable("employeerecords")
                .HasKey(e => e.Id);

            modelBuilder
                .Entity<EmployeeInfo>()
                .Property<string>(e => e.EmpName)
                .HasColumnName("name")
                .HasColumnType("varchar(50)")
                .IsRequired();

            modelBuilder
                .Entity<EmployeeInfo>()
                .Property<string>(e => e.Emp_Dept)
                .HasColumnName("department")
                .HasColumnType("varchar(20)");

            modelBuilder
                .Entity<EmployeeInfo>()
                .Property<decimal>(e => e.EmpSalary)
                .HasColumnName("salary")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

        }
    }
}
