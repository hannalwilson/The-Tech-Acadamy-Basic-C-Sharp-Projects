using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListsContinued
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "steak", "tacos", "pizza", "dirt", "soup", "water" };


            Console.WriteLine("Find out what you're having for dinner, pick a number 0 - 5!");
            string dinner = Console.ReadLine();
            int din = Convert.ToInt32(dinner);

            if (din < 6)
            {
                Console.WriteLine("You are eating " + stringArray[din] + " for dinner.");
                Console.ReadLine();

                int[] intArray = { 10, 3, 25, 2, 4, 100 };

                Console.WriteLine("Now find out how many days in a row you are eating that for dinner, pick another number 0 - 5!");
                string numDays = Console.ReadLine();
                int days = Convert.ToInt32(numDays);

                if (days < 6)
                {
                    Console.WriteLine("You will eat that " + intArray[days] + " days in a row.");
                    Console.ReadLine();

                    List<string> praiseList = new List<string>
                    {
                        "You get a gold star!",
                        "You're a genius!",
                        "You're amazing!",
                        "You're awesome!",
                        "I'm proud of you!",
                        "You're fantastic!"
                    };

                    Console.WriteLine("Before I leave you, let's pick one more number 0 - 5.");
                    string yourPraise = Console.ReadLine();
                    int praise = Convert.ToInt32(yourPraise);

                    if (praise < 6)
                    {
                        Console.WriteLine(praiseList[praise]);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("I said pick a number between 0 and 5! You can't even follow simple directions!");
                        Console.ReadLine();
                    }
                    
                }
                else
                {
                    Console.WriteLine("I said pick a number between 0 and 5! You can't even follow simple directions!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("I said pick a number between 0 and 5! You can't even follow simple directions!");
                Console.ReadLine();
            }

            
        }
    }
}
