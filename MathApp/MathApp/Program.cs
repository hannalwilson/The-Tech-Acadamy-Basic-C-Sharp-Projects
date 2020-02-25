using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number:");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);
            int total1 = num1 * 50;
            Console.WriteLine(num1 + " times 50 is: " + total1);
            Console.ReadLine();

            Console.WriteLine("Pick another number:");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);
            int total2 = num2 + 25;
            Console.WriteLine(num2 + " plus 25 is: " + total2);
            Console.ReadLine();

            Console.WriteLine("Yet again, pick a number:");
            string number3 = Console.ReadLine();
            double num3 = Convert.ToDouble(number3);
            double total3 = num3 / 12.5;
            Console.WriteLine(num3 + " divided by 12.5 is: " + total3);
            Console.ReadLine();

            Console.WriteLine("One more time, pick a number:");
            string number4 = Console.ReadLine();
            int num4 = Convert.ToInt32(number4);
            bool isGreater = num4 > 50;
            Console.WriteLine(num4 + " is greater than 50: " + isGreater);
            Console.ReadLine();

            Console.WriteLine("Last time I promise, pick a number:");
            string number5 = Console.ReadLine();
            int num5 = Convert.ToInt32(number5);
            int total5 = num5 % 7;
            Console.WriteLine("When " + num5 + " is divided by 7, the remainder is: " + total5);
            Console.ReadLine();
        }
    }
}
