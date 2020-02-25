using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            string hourlyRate1 = Console.ReadLine();

            Console.WriteLine("How many hours do you work per week?");
            string workHours1 = Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string hourlyRate2 = Console.ReadLine();

            Console.WriteLine("How many hours do you work per week?");
            string workHours2 = Console.ReadLine();

            int rate1 = Convert.ToInt32(hourlyRate1);
            int hours1 = Convert.ToInt32(workHours1);
            int salary1 = rate1 * hours1 * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);

            int rate2 = Convert.ToInt32(hourlyRate2);
            int hours2 = Convert.ToInt32(workHours2);
            int salary2 = rate2 * hours2 * 52;
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);

            bool makeMore = salary1 > salary2;

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(makeMore);
            Console.ReadLine();

        }
    }
}
