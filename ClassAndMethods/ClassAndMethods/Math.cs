using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods
{
    public class Math
    {
        public static void Addition(int numAdd, out int resultAdd)
        {
            resultAdd = numAdd + 10;
        }

        public static void Subtraction(int numSub, out int resultSub)
        {
            resultSub = 100 - numSub;
        }

        public static void Multiply(int numMult, out int resultMult)
        {
            resultMult = numMult * 3;
        }
    }
}
