using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step117
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine("Enter a whole number to get devided by 2");
            Class1.DivTwo(out x, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("the new number is " + x);
            Console.ReadLine();
        }
    }
}
