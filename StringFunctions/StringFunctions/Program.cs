using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Hanna";
            //string quote = "The man said, \"Hello\", Hanna. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Hanna";

            //bool trueOrFalse = name.Contains("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(quote);
            //Console.WriteLine(fileName);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(length);
            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Hanna");


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
