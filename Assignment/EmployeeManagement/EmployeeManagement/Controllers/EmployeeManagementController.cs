using BusinessLayer.Interface;
using CommonLayer;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeManagementController : ControllerBase
    {
        private readonly IEmployeeBL _employeeBusiness;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public EmployeeManagementController(IEmployeeBL employeeBusiness)
        {
            _employeeBusiness = employeeBusiness;
        }
        [HttpGet]
        public string Get()
        {
            return "Server running..";
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            try
            {
                _logger.Info("Received request to add employee: {Name}", employee.Name);
                _employeeBusiness.AddEmployee(employee);
                _logger.Info("Employee added successfully: {Name}", employee.Name);
                return Ok("Employee added successfully");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Internal Server Error while adding employee: {Name}", employee.Name);
                return StatusCode(500, new { message = "Internal Server Error", error = ex.Message });
            }
        }


    }
}
