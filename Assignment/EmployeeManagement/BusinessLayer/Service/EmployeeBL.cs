using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using CommonLayer;
using NLog;
using RepositoryLayer.Interface;

namespace BusinessLayer.Service
{
    public class EmployeeBL:IEmployeeBL
    {
        private readonly IAddEmployee _employeeRepository;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public EmployeeBL(IAddEmployee employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void AddEmployee(Employee employee)
        {
            try
            {
                _logger.Info("Processing employee addition: {Name}", employee.Name);
                _employeeRepository.AddEmployee(employee);
                _logger.Info("Employee addition successful: {Name}", employee.Name);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Business logic error: Unable to add employee: {Name}", employee.Name);
                throw new Exception("Business logic error: Unable to add employee.", ex);
            }
        }

    }
}
