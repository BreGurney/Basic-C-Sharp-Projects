using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working
{
    class Employee
    {
        public List<Employee> Employees { get; set; }
        public int Hours { get; set; }
        public string Name { get; set; }
        public bool isActivelyWorking { get; set; }
    }
}
