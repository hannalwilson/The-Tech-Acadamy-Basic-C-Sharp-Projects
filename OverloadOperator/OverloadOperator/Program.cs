using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { ID = 1 };
            Employee emp2 = new Employee() { ID = 2 };

            bool isEqual = emp1.ID == emp2.ID;

            if (isEqual == true)
            {
                Console.WriteLine("The employees are equal.");
            }
            else
            {
                Console.WriteLine("The employees are not equal.");
            }

            Console.ReadLine();

        }

    }
    
}
