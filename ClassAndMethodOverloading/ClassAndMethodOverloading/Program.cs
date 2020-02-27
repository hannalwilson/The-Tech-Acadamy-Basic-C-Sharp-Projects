using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Math math = new Math();
            int result = math.MathOperation(number);
            Console.WriteLine(number + " + 50 = " + result);

            Console.WriteLine("Pick another number, with a decimal:");
            decimal numberDec = Convert.ToDecimal(Console.ReadLine());
            int resultDec = math.MathOperation(numberDec);
            Console.WriteLine(numberDec + " x 5 = " + resultDec);

            Console.WriteLine("One last time, pick a number:");
            string numberStr = Console.ReadLine();
            int resultStr = math.MathOperation(numberStr);
            Console.WriteLine(numberStr + " - 1 = " + resultStr);

            Console.ReadLine();
        }
    }
}
