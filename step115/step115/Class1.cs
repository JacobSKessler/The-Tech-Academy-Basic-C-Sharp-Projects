using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step115
{
    class Class1
    {
        public int TimesFive(int x, int y = 1)
        {
            for (int i = 0; i < y; i++)
            {
                x = x * 5;
            }
            return x;
        }

    }
}
