using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the age you will be turning this year.");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age == 0)
                {
                    throw new ZeroException();
                }
                else if (age < 0)
                {
                    throw new NegException();
                }
                DateTime birthYear = DateTime.Now.AddYears(-age);
                Console.WriteLine("You were born in {0}.", birthYear.Year);
                Console.ReadLine();
            }
            catch (ZeroException)
            {
                Console.WriteLine("Infants can't use computers! Please enter a valid age.");
                Console.ReadLine();
            }
            catch (NegException)
            {
                Console.WriteLine("You can't live negative years! Please enter a valid age, greater than 0.");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Oops! Enter your age as an integer please.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Uh oh! Something went wrong! Goodbye.");
                Console.ReadLine();
            }
            
            

            
        }
    }
}
