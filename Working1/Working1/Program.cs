using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working1
{
    class Program
    {
        static void Main(string[] args)
        {
            Work work = new Work();
            Employee employee = new Employee();
            employee.FirstName = "Test";
            work += employee;
            work -= employee;

            Console.ReadLine();

        }
    }
}
