using EmployeeServiceWebAPI.Repository;
using Microsoft.EntityFrameworkCore;

namespace EmployeeServiceWebAPI
{
    public class Program
    {
        public static void Main()
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder();
            //ServiceCollection services = new ServiceCollection();
            IServiceCollection container = builder.Services;

            //before build configure all service dependencies
            container.AddDbContext<EmployeeDbContext>((builder) =>
            {
                builder.UseSqlServer(@"Data Source=joydip-pc\sqlexpress;Initial Catalog=employeedb;User ID=sa;Password=SqlServer@2022;Encrypt=False");
            });
            container.AddControllers();
            
            //container.AddControllersWithViews();


            WebApplication app = builder.Build();

            app.UseAuthorization();
            //after build use the middlewares
            app.MapControllers();

            app.Run();
        }
    }
}
