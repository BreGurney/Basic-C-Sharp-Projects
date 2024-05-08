using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working1
{
    class Employee //Players
    {
        public List<Employee> Employees { get; set; }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public static Work operator+ (Work work, Employee employee)
        {
            work.Employees.Add (employee);
            return work;
        }
        public static Work operator- (Work work, Employee employee)
        {
            work.Employees.Remove (employee);
            return work;
        }
    }
}
