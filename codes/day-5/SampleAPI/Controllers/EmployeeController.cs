using SampleAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SampleAPI.Controllers
{
    //attributed routing
    [ApiController]
    [Route("[controller]")] //http://localhost:5149/employee
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeDbContext _employeeDbContext;
        public EmployeeController(EmployeeDbContext employeeDbContext)
        {
            this._employeeDbContext = employeeDbContext;
        }

        [HttpGet]
        [Route("records")] //http://localhost:5149/employee/records
        public ActionResult FetchEmployees()
        {
            try
            {
                DbSet<EmployeeInfo> reccords = _employeeDbContext.EmployeeInfos;
                OkObjectResult result = this.Ok(reccords);
                return result;
            }
            catch (Exception)
            {
                return this.NotFound("some issues happened");
            }
        }
    }
}
