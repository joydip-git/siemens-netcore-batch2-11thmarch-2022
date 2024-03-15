using DataAccessUsingEFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace DataAccessUsingEFCore
{
    internal class Program
    {
        static void PrintRecords(EmployeeDbContext db)
        {
            //SiemensDbContext
            //EmployeeDbContext db = new EmployeeDbContext();
            DbSet<EmployeeInfo> reccords = db.EmployeeInfos;
            reccords.ToList().ForEach(e => Console.WriteLine(e));
            //db.Dispose();
        }
        static void AddRecord(EmployeeDbContext db)
        {
            //EmployeeDbContext db = new EmployeeDbContext();
            DbSet<EmployeeInfo> reccords = db.EmployeeInfos;
            reccords.Add(new EmployeeInfo { EmpName = "Ramnath", EmpSalary = 1000, Emp_Dept = "HR" });
            int res = db.SaveChanges();
            Console.WriteLine(res > 0 ? "Added" : "Failed");
            //db.Dispose();
        }
        static void UpdateRecord(EmployeeDbContext db)
        {
            //EmployeeDbContext db = new EmployeeDbContext();
            DbSet<EmployeeInfo> reccords = db.EmployeeInfos;
            EmployeeInfo found = reccords.Where(e => e.Id == 1).First();
            found.EmpName = "Anil Kumar";
            found.EmpSalary = 1000;
            found.Emp_Dept = "HR";
            int res = db.SaveChanges();
            Console.WriteLine(res > 0 ? "Updated" : "Failed");
            //db.Dispose();
        }
        static void DeleteRecord(EmployeeDbContext db)
        {
            //EmployeeDbContext db = new EmployeeDbContext();
            DbSet<EmployeeInfo> reccords = db.EmployeeInfos;
            EmployeeInfo found = reccords.Where(e => e.Id == 6).First();
            reccords.Remove(found);
            int res = db.SaveChanges();
            Console.WriteLine(res > 0 ? "Deleted" : "Failed");
            //db.Dispose();
        }
        static void Main()
        {
            try
            {
                IServiceCollection container = new ServiceCollection();
                IServiceProvider provider = container
                    .AddDbContext<EmployeeDbContext>(
                    (DbContextOptionsBuilder builder) =>
                    {
                        builder.UseSqlServer(@"Data Source=joydip-pc\sqlexpress;Initial Catalog=employeedb;User ID=sa;Password=SqlServer@2022;Encrypt=False");
                    }
                    )
                    .BuildServiceProvider();

                EmployeeDbContext db = provider.GetRequiredService<EmployeeDbContext>();
                //EmployeeDbContext db = new EmployeeDbContext();
                //AddRecord(db);
                //UpdateRecord();
                //DeleteRecord();
                PrintRecords(db);
                db.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
