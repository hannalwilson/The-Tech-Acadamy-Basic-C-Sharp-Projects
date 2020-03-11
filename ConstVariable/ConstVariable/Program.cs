using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            const string title = "Queen";
            var name = "Hanna";

            Royalty royalty = new Royalty(title);
            Console.WriteLine("{0} {1} says \"{2}\"", royalty.Title, name, royalty.Phrase);

            Console.ReadLine();
        }
    }
}
