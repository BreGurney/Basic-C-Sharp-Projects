using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Assignment
{
    public class Employee
    {
        public List<Employee> Employees { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public static Work operator+ (Employee employee, Work work)
        {
            work.Employees.Add(employee);
            return work;
        }
        public static Work operator- (Employee employee, Work work)
        {
            work.Employees.Remove(employee);
            return work;
        }
        Employee employee = new Employee()
        {
            ID = 1,
            FirstName = "Bob"
        };
    }
}
