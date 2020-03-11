using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVariable
{
    class Royalty
    {
        public Royalty(string title) : this(title, "Bow down peasants!")
        {

        }
        public Royalty(string title, string phrase)
        {
            Title = title;
            Phrase = phrase;

        }

        public string Title { get; set; }
        public string Phrase { get; set; }
    }
}
