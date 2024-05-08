using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working
{
    class Shift : Job, IQuittable
    {
        public override void Work()
        {
            throw new NotImplementedException();
        }
        public override void ListEmployees()
        {
            Console.WriteLine("3 Employees");
            base.ListEmployees();
        }
        public void Quit(Employee emplpyees)
        {
            throw new NotImplementedException();
        }
        Console.WriteLine("Employee has Quit.");
        Console.ReadLine();

    }
}
