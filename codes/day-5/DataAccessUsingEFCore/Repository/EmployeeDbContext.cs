using Microsoft.EntityFrameworkCore;

namespace DataAccessUsingEFCore.Repository
{
    //public class SiemensDbContext : DbContext
    public class EmployeeDbContext : DbContext
    {
        //public SiemensDbContext(string connectionString) : base(connectionString)
        //{

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }

        public DbSet<EmployeeInfo> EmployeeInfos { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=joydip-pc\sqlexpress;Initial Catalog=siemensdb;User ID=sa;Password=SqlServer@2022;Encrypt=False");
            //optionsBuilder.UseSqlServer(@"Data Source=joydip-pc\sqlexpress;Initial Catalog=employeedbtest;User ID=sa;Password=SqlServer@2022;Encrypt=False");
            optionsBuilder.UseSqlServer(@"Data Source=joydip-pc\sqlexpress;Initial Catalog=employeedb;User ID=sa;Password=SqlServer@2022;Encrypt=False");
        }
        */

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
