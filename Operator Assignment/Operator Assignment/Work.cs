using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Assignment
{
    public abstract class Work
    {
        public List<Employee> Employees { get; set; }
        public string FirstName { get; set; }
        public int EmployeeID { get; set; }

        public virtual void ListEmployees()
        {
            Employees = new List<Employee>();
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee.FirstName, EmployeeID);
            }
        }
    }
}
