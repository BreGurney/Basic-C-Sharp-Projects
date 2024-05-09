using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Assignment
{
    class Program : Employee
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Bob";
            employee.LastName = "Peters";
            Employee employee1 = new Employee();
            employee1.FirstName = "Breanne";
            employee1.LastName = "Gurney";

            Console.WriteLine(employee.FirstName + employee.ID);
            Console.ReadLine();

        }
    }
}
