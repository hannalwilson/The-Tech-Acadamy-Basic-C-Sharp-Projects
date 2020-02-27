using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodOverloading
{
    public class Math
    {
        public int MathOperation(int number)
        {
            int result = number + 50;
            return result;
        }

        public int MathOperation(decimal number)
        {
            int result = Convert.ToInt32(number * 5);
            return result;
        }

        public int MathOperation(string number)
        {
            int result = Convert.ToInt32(number) - 1;
            return result;
        }
    }
}
