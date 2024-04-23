using System;


namespace MathAndCamparisonOperationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous IncomeComparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hours1 = Console.ReadLine();
            int salary1 = Console.ToInt32(hourlyRate1) * Convert.ToInt32().ToInt32(hours1) * 52;
            Console.WriteLine("Person2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hours2 = Console.ReadLine();
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2);
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);
            Console.WriteLine("Annualy salary of Person 2:");
            Console.WriteLine(salary2);
            Console.WriteLine(isMore);
            Console.ReadLine();
        }
    }
}
