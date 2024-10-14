using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApplication
{
    public class PartTimeEmployee : IEmployee
    {
        private string First_Name;
        private string Last_Name;
        private string department;
        private string job_title;
        private double basic_salary;

        public string FirstName 
        {
            get {
                return First_Name;
            }
            set {
                First_Name = value;
            }
        }

        public string LastName 
        {
                get
                {
                    return Last_Name;
                }
                set
                {
                    Last_Name = value;
                }
        }

        public string Department 
        {
            get 
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        public string JobTitle 
        {
            get 
            {
                return job_title;
            }
            set 
            {
                job_title = value;
            }

        }
        public double BasicSalary
        {
            get 
            {
                return basic_salary;
            }
            set 
            {
                basic_salary = value;
            }
        }

        public PartTimeEmployee(string Fname, string Lname, string dept, string job)
        {
            First_Name = Fname;
            Last_Name = Lname;
            department = dept;
            job_title = job;
            
        }

        public void computeSalary(int hoursWorked, double ratePerHour) 
        {
            basic_salary = hoursWorked * ratePerHour;
        }

        public double GetSalary() 
        {
            return basic_salary;
        }
    }
}
