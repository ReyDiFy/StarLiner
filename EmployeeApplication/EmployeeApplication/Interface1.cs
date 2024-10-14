using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApplication
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Department { get; set; }
        string JobTitle { get; set; }
        double BasicSalary { get; set; }
        void computeSalary(int HoursWorked, double ratePerHour);
        
    }
}
