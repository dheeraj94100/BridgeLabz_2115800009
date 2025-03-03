using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;
using NLog;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;

namespace RepositoryLayer.Service
{
    public class EmployeeService: IAddEmployee
    {
        private readonly EmployeeContext _context;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        public EmployeeService(EmployeeContext context) 
        {
            _context = context;
        }
        public void AddEmployee(Employee employee)
        {
            // Implementation logic here
            try
            {
                _logger.Info("Adding a new employee: {Name}", employee.Name);
                _context.Employees.Add(employee);
                _context.SaveChanges();
                _logger.Info("Employee added successfully: {Name}", employee.Name);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "An error occurred while adding the employee: {Name}", employee.Name);
                throw new Exception("An error occurred while adding the employee.", ex);
            }

        }

    }
}
