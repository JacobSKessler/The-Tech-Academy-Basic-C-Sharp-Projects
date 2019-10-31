using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step137
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number { Amount = 2.222M };

            Console.WriteLine(num.Amount);
            Console.ReadLine();
        }
    }
}
