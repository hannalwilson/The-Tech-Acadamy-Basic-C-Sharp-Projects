using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I bet you can't guess my favorite color.");
            Console.WriteLine("Go ahead, what do you think it is?");
            string color = Console.ReadLine();
            bool isGuessed = color == "purple";

            do
            {
                switch (color)
                {
                    case "blue":
                        Console.WriteLine("Not quite, but you are close...");
                        Console.WriteLine("Guess again?");
                        color = Console.ReadLine();
                        break;
                    case "pink":
                        Console.WriteLine("Not quite, but you are close...");
                        Console.WriteLine("Guess again?");
                        color = Console.ReadLine();
                        break;
                    case "purple":
                        Console.WriteLine("Wow, you guessed it right! Are you a mind reader?");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Wrong! I knew you couldn't guess it.");
                        Console.WriteLine("Guess again?");
                        color = Console.ReadLine();
                        break;
                }

            }
            while (!isGuessed);
                
            Console.ReadLine();

            Console.WriteLine("Now, can you guess what shade of purple I like?");
            Console.WriteLine("I'll give you a hint...");
            Console.WriteLine("It is either lavender, violet, eggplant, or wine.");
            string shade = Console.ReadLine();
            bool isPicked = false;

            while (!isPicked)
            {
                switch (shade)
                {
                    case "lavender":
                        Console.WriteLine("You're wrong, lavender is too light for me.");
                        Console.WriteLine("Guess again?");
                        shade = Console.ReadLine();
                        break;
                    case "violet":
                        Console.WriteLine("You're wrong, violet is nice but not for me.");
                        Console.WriteLine("Guess again?");
                        shade = Console.ReadLine();
                        break;
                    case "eggplant":
                        Console.WriteLine("You're wrong, I love to eat eggplants but the color isn't my favorite.");
                        Console.WriteLine("Guess again?");
                        shade = Console.ReadLine();
                        break;
                    case "wine":
                        Console.WriteLine("You got it! Wine is also one of my favorite beverages.");
                        isPicked = true;
                        break;
                    default:
                        Console.WriteLine("Hello! Are you dumb? I told you it was either lavender, violet, eggplant, or wine!!");
                        Console.WriteLine("I shouldn't give you another chance, but I'm feeling generous. Guess again?");
                        shade = Console.ReadLine();
                        break;
                }
            }
                
            Console.ReadLine();

            
        }
    }
}
