using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            int numOne = 450;
            int numTwo = 10;
            math.MathOperation(numOne, numTwo);
            Console.ReadLine();

        }
    }
}
