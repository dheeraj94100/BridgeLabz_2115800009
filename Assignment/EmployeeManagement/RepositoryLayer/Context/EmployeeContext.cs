using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Context
{
    public class EmployeeContext : DbContext
    {
            public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

            public DbSet<Employee> Employees { get; set; }

        
    }
}
