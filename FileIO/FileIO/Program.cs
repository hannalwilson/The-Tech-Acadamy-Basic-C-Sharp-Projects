using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Desktop\Logs\log.txt", true))
            {
                file.WriteLine(answer);
            }

            using (StreamReader readFile = new StreamReader(@"C:\Users\Student\Desktop\Logs\log.txt"))
            {
                string line = readFile.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = readFile.ReadLine();
                }
                readFile.Close();
            }
            Console.ReadLine();
              
        }
    }
}
