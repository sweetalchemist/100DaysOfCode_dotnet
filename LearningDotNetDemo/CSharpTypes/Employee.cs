using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypes
{
    public class Employee
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = String.Empty;

        public string Email { get; set; }= string.Empty;
        public int HoursWorked { get; set; }
        public double Wages { get; set; }
        public double HourlyRate { get; set; }
        public DateTime Birthday { get; set; }

        public EmployeeType EmployeeType { get; set; }
        public void PerformWork()
        {
            HoursWorked++;

            Console.WriteLine($"Employee {FirstName} {LastName} is now working for {HoursWorked} hours!");
        }


    }
}
