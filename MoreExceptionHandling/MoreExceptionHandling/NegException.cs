using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptionHandling
{
    public class NegException : Exception
    {
        public NegException() 
            : base() { }
        public NegException(string message)
            : base(message) { }
    }
}
