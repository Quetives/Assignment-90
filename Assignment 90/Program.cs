using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Decimal Hr1, Hr2, Hw1, Hw2, annual, weekly1, weekly2, salary1, salary2;
            String rate1, rate2, worked1, worked2;
            bool greater;
            annual = 52;

            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly Rate?");
            rate1 = Console.ReadLine();
            Hr1 = Convert.ToDecimal(rate1);
            
            Console.WriteLine("Hours worked per week?");
            worked1 = Console.ReadLine();
            Hw1 = Convert.ToDecimal(worked1);
            

            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate?");
            rate2 = Console.ReadLine();
            Hr2 = Convert.ToDecimal(rate2);
            
            Console.WriteLine("Hours worked per week?");
            worked2 = Console.ReadLine();
            Hw2 = Convert.ToDecimal(worked2);
            

            weekly1 = Hr1 * Hw1;
            salary1 = weekly1 * annual;
            Console.WriteLine("Annual salary of Person 1");
            Console.WriteLine(salary1);

            weekly2 = Hr2 * Hw2;
            salary2 = weekly2 * annual;
            Console.WriteLine("Annual salary of Person 2");
            Console.WriteLine(salary2);

            greater = salary1 > salary2;

            Console.WriteLine("Does Person 1 make more money than person 2?");
            Console.WriteLine(greater);
            Console.ReadLine();
        }
    }
}
