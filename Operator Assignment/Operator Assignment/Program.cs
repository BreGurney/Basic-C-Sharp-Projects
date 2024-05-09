using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
            employee.ID = 1;
            Employee employee1 = new Employee();
            employee1.FirstName = "Breanne";
            employee1.LastName = "Gurney";
            employee.ID = 2;


            Console.WriteLine(employee == employee1);
            Console.ReadLine();
        }
    }
}
