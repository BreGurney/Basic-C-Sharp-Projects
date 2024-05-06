using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOp = new MathOperation();
            Console.WriteLine("Enter an integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second integer, or just press enter: ");
            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                int results = mathOp.MathOperation(num1, num2);
                Console.WriteLine(num1 + " x " + num2 + " = " + result);
            }
            catch
            {
                int results = mathOp.MathOperation(num1);
                Console.WriteLine(num1 + " x Default 1 = " + results);
            }
            Console.ReadLine();
        }
    }
}
