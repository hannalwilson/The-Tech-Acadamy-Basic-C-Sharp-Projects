using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Pick a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If you want to, pick another number, otherwise just press enter again.");
            string optionalNumber = Console.ReadLine();


            if (optionalNumber == "")
            {
                int answer = math.MathOperation(number);
                Console.WriteLine("10 x " + number + " / 2 = " + answer);
                Console.ReadLine();
            }
            else
            {
                int number2 = Convert.ToInt32(optionalNumber);
                int answer2 = math.MathOperation(number, number2);
                Console.WriteLine("10 x " + number + " / " + number2 + " = " + answer2);
                Console.ReadLine();
            }
         
            
        }
    }
}
