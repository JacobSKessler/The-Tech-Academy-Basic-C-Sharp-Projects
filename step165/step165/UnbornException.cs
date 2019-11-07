using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step165
{
    class UnbornException : Exception
    {
        public UnbornException() : base() { }
        public UnbornException(string message) : base(message) { }
    }
}
