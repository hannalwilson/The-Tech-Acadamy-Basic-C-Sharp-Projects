using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int> { 40, 22, 36, 4, 8, 50 };

                Console.WriteLine("Pick a number, any number!");
                int divisor = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i] = numbers[i] / divisor;
                    Console.WriteLine(numbers[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("The program has emerged from the try/catch block.");
            Console.ReadLine();
        }
    }
}
