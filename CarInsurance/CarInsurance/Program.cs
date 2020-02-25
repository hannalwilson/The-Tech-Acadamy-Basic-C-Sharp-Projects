using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string custAge = Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?");
            string hadDUI = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string numberTickets = Console.ReadLine();

            int age = Convert.ToInt32(custAge);
            bool DUI = Convert.ToBoolean(hadDUI);
            int tickets = Convert.ToInt32(numberTickets);

            bool qualifies = age > 15 && DUI == false && tickets <= 3;

            Console.WriteLine("Qualified?");
            Console.WriteLine(qualifies);

            Console.ReadLine();
        }
    }
}
