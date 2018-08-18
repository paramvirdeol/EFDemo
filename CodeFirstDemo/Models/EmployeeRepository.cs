using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    public class EmployeeRepository
    {
        public List<Department> GetDepartments()
        {
            var dbContext = new EmployeeDBContext();
            var dummy= dbContext.Departments.Include("Employees").ToList();
            return dummy;
        }
    }
}