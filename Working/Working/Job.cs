using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working
{
    public abstract class Job
    {
        public List<string> Employee { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public abstract void Work();

        public virtual void ListEmployees()
        {
            foreach (string employee in Employee)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
