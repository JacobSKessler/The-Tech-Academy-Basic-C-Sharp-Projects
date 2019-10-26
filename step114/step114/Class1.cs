using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step114
{
    class Class1
    {
        public static int Change(string x)
        {
            return Convert.ToInt32(x) + 5;
        }

        public static int Change(decimal x)
        {
            return Convert.ToInt32( x / 2);
        }

        public static int Change(int x)
        {
            return x * 2;
        }

    }
}
