using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working1
{
    class Work : Employee 
    {
        public new List<Employee> Employees { get; set; }
        public int EmployeesID { get; set; }

        public string FistName { get; set; }
        public new string LastName { get; set; }

        public virtual void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee.FirstName, EmployeeID);
            }
        }
    }
}
