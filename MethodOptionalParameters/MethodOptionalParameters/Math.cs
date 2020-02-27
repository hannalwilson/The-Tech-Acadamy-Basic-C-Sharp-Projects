using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionalParameters
{
    public class Math
    {
        public int MathOperation(int numOne, int numTwo = 2)
        {
            int result = 10 * numOne / numTwo;
            return result;
        }
    }
}
