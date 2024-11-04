using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class NumberFormatException : Exception
    {
        public NumberFormatException(string msg) : base(msg) { }
    }
    public class StringFormatException : Exception 
    {
        public StringFormatException(string msg) : base(msg) { }
    }
    public class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string msg) : base(msg) { }
    }

    
}
