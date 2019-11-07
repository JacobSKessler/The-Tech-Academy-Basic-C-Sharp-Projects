using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step165
{
    public class BabyException : Exception
    {
        public BabyException() : base() { }
        public BabyException(string message) : base(message) { }
    }
}
