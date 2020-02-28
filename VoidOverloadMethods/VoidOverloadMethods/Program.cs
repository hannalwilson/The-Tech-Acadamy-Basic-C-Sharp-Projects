using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidOverloadMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Enter a number, or else.");
            int num = Convert.ToInt32(Console.ReadLine());

            int result;
            Math.Divide(num, out result);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
