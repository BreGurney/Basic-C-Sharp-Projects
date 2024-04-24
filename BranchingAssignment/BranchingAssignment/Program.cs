using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight.");
            int weight = (Convert.ToInt32(Console.ReadLine()));
            if (weight > 50) { 
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return; //This will end the program if the weight is over 50
            }
            Console.WriteLine("Please enter the package width.");
            int width = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Please enter the package height");
            int height = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Please enter the package length");
            int length = (Convert.ToInt32(Console.ReadLine()));
            int tooBig = Convert.ToInt32(length + width + height);
            if (tooBig > 50) {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
            int estimate = (Convert.ToInt32(length * width * height) * weight / 100); 
            Console.WriteLine("Your estimated total for shipping this package is: $" + estimate);
            Console.WriteLine("Thankk you!");
            Console.ReadLine();
            return;




            Console.ReadLine();
        }
    }
}
