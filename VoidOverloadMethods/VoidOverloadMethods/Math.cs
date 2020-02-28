using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidOverloadMethods
{
    public class Math
    {
        public static void Divide(int num, out int result)
        {
            result = num / 2;

        }

        public static void Output(out int numOne, out int numTwo)
        {
            numOne = 1;
            numTwo = 2;
        }

        public static void Output(out int numOne, out int numTwo, out int numThree)
        {
            numOne = 100;
            numTwo = 200;
            numThree = 300;
        }
    }
}
