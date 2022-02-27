using CSharpGenerics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenerics.Repositories
{
    public class EmployeeRepository
    {
        private readonly List<Employee> _employees = new();

        public void Add(Employee item)
        {
            _employees.Add(item);
        }

        public void Save()
        {
            foreach (Employee item in _employees)
            {
                Console.WriteLine(item);
            }
        }

    }
}
