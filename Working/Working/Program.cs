using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working
{
    class Program
    {
        static void Main(string[] args)
        {
            Shift job = new Shift();
            job.Employee = new List<string> { "Breanne", "Lucas", "Roland" };
            job.ListEmployees();
            Console.ReadLine();
        }
    }
}
