using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello and welcome to my string practice console! ";
            string enjoy = ", I hope you enjoy what you see!";

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine(greeting + name + enjoy);
            Console.ReadLine();

            string ready = "get ready for the next part!!!!!";
            ready = ready.ToUpper();

            Console.WriteLine(ready);
            Console.ReadLine();

            StringBuilder paragraph = new StringBuilder("Guess what!? ");

            paragraph.Append("I'm practicing different things you can do with strings in Visual Studio. ");
            paragraph.Append("I've learned how to concatenate strings. ");
            paragraph.Append("I've also learned how to convert a string to upper or lower case. ");
            paragraph.Append("Now, I'm learning stringbuilder. ");
            paragraph.Append("It's pretty neat! ");
            paragraph.Append("You probably can't tell but I am building this paragraph one sentence at a time. ");
            paragraph.Append("I can do that by utilizing stringbuilder and the append function. ");
            paragraph.Append("At least, I hope that is how I'm supposed to do it...");
            Console.WriteLine(paragraph);
            Console.ReadLine();

        }
    }
}
