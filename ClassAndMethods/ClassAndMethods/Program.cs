using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int result;
            Math.Addition(num, out result);
            Console.WriteLine(num + " + 10 = " + result);
            Console.ReadLine();

            Math.Subtraction(num, out result);
            Console.WriteLine("100 - " + num + " = " + result);
            Console.ReadLine();

            Math.Multiply(num, out result);
            Console.WriteLine(num + " x 3 = " + result);
            Console.ReadLine();
        }
    }
}
