using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("The current date and time is: ");
            Console.WriteLine(now);
            Console.WriteLine("\n\nPlease enter a number. ");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nIn {0} hours, the date and time will be {1}.", hours, now.AddHours(hours));
            
            Console.ReadLine();


        }
    }
}
